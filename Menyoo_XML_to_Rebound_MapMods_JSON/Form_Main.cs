using System.Globalization;
using System.Text;
using System.Xml.Linq;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Menyoo_XML_to_Rebound_MapMods_JSON
{
    public partial class Form_Main : Form
    {

        private const string InstallLocKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Rockstar Games\Grand Theft Auto V";
        private const string InstallLocValue = "InstallFolder";

        private string GTAVFolder = string.Empty;

        private int ListBoxRightClickedIndex = -1;

        public Form_Main()
        {
            InitializeComponent();

            lbXMLFiles.DragDrop += new DragEventHandler(lbXMLFiles_DragDrop);
            lbXMLFiles.DragEnter += new DragEventHandler(lbXMLFiles_DragEnter);

            openFileDialog_XMLFiles.Filter = "XML Files (*.XML)|*XML";
            this.openFileDialog_XMLFiles.RestoreDirectory = true;
            this.openFileDialog_XMLFiles.Title = "Add XML File/s";

            try
            {
                var gtaFolderVal = Registry.GetValue(InstallLocKey, InstallLocValue, string.Empty); 
                if (gtaFolderVal is string ThePath && !string.IsNullOrWhiteSpace(ThePath))
                {
                    GTAVFolder = ThePath;
                }
            }
            catch (Exception) // Ignore if not found or something
            {
            }

            if (!string.IsNullOrWhiteSpace(GTAVFolder) && Directory.Exists(Path.Combine(GTAVFolder, "menyooStuff", "Spooner")))
            {
                openFileDialog_XMLFiles.InitialDirectory = Path.Combine(GTAVFolder, "menyooStuff", "Spooner");
                //MessageBox.Show(Path.Combine(GTAVFolder, "menyooStuff", "Spooner"));
            }




            folderBrowserDialog_OutputFolder.ShowNewFolderButton = true;

            if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Rebound", "Map Mods")))
            {
                folderBrowserDialog_OutputFolder.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Rebound", "Map Mods");
                tbOutputFolder.Text = folderBrowserDialog_OutputFolder.InitialDirectory;
            }


            // Empty Init Focus workaround
            this.ActiveControl = label1;
            label1.Focus();
        }

        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        FileInfo fi = new FileInfo(f);
                        if (!lbXMLFiles.Items.Contains(f) && fi.Extension.ToLower() == ".xml" && ShortMenyooXMLCheck(f))
                        {
                            lbXMLFiles.Items.Add(f);
                        }
                    }
                    DirSearch(d);
                }
            }
            catch (Exception)
            {
                //Console.WriteLine(excpt.Message);
            }
        }

        private void lbXMLFiles_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var item in s)
            {
                //lbXMLFiles.Items.Add(item);
                FileAttributes attr = File.GetAttributes(item);
                if (attr == FileAttributes.Directory)
                {
                    foreach (string f in Directory.GetFiles(item))
                    {
                        FileInfo fi = new FileInfo(f);
                        if (!lbXMLFiles.Items.Contains(f) && fi.Extension.ToLower() == ".xml" && ShortMenyooXMLCheck(f))
                        {
                            lbXMLFiles.Items.Add(f);
                        }
                    }

                    // recursive sub folders
                    DirSearch(item);
                }
                else
                {
                    FileInfo fi = new FileInfo(item);
                    if (!lbXMLFiles.Items.Contains(item) && fi.Extension.ToLower() == ".xml" && ShortMenyooXMLCheck(item))
                    {
                        lbXMLFiles.Items.Add(item);
                    }
                }

            }
        }

        private void lbXMLFiles_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private bool ShortMenyooXMLCheck(string Path)
        {
            XDocument xdoc = XDocument.Load(Path);
            if (xdoc.Root == null)
            {
                return false;
            }
            if (xdoc.Root.Name == "SpoonerPlacements")
            {
                return true;
            }

            return false;
        }

        private void ConvertXML(string PathToXML)
        {
            try
            {
                StringBuilder result = new StringBuilder();


                //Load xml
                XDocument xdoc = XDocument.Load(PathToXML);


                JArray MainJArray = new JArray();

                var lv1s = from lv1 in xdoc.Descendants("Placement")
                           select new
                           {
                               Header = lv1.Name,
                               Children = lv1.Descendants()
                           };

                if (lv1s.Count() < 1)
                {
                    return;
                }

                //Loop through results
                foreach (var lv1 in lv1s)
                {
                    try
                    {
                        JArray ja = new JArray();
                        ja.Add(lv1.Children.First(e => e.Name.ToString() == "HashName").Value);

                        ja.Add(Convert.ToInt64(lv1.Children.First(e => e.Name.ToString() == "ModelHash").Value, 16));

                        var PosRot = lv1.Children.First(e => e.Name.ToString() == "PositionRotation").Descendants();
                        ja.Add(Decimal.Parse(PosRot.First(p => p.Name.ToString() == "X").Value, NumberStyles.Any, CultureInfo.InvariantCulture));
                        ja.Add(Decimal.Parse(PosRot.First(p => p.Name.ToString() == "Y").Value, NumberStyles.Any, CultureInfo.InvariantCulture));
                        ja.Add(Decimal.Parse(PosRot.First(p => p.Name.ToString() == "Z").Value, NumberStyles.Any, CultureInfo.InvariantCulture));
                        ja.Add(Decimal.Parse(PosRot.First(p => p.Name.ToString() == "Pitch").Value, NumberStyles.Any, CultureInfo.InvariantCulture));
                        ja.Add(Decimal.Parse(PosRot.First(p => p.Name.ToString() == "Roll").Value, NumberStyles.Any, CultureInfo.InvariantCulture));
                        ja.Add(Decimal.Parse(PosRot.First(p => p.Name.ToString() == "Yaw").Value, NumberStyles.Any, CultureInfo.InvariantCulture));


                        ja.Add(0.0d);
                        ja.Add(0.0d);
                        ja.Add(0.0d);

                        MainJArray.Add(ja);



                    }
                    catch (Exception) // Skip Whole Elem
                    {
                        continue;
                    }

                }

                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(PathToXML);
                    if (string.IsNullOrWhiteSpace(fileName))
                    {
                        return;
                    }
                    File.WriteAllText(Path.Combine(tbOutputFolder.Text, fileName + ".json"), MainJArray.ToString());
                }
                catch (Exception) // Silent Skip
                {

                }

                //richTextBox1.Text = MainJArray.ToString();

                //Console.WriteLine(result);
                //MessageBox.Show(result.ToString());
            }
            catch (Exception) // Silent Skip whole XML
            {

            }
        }

        private void btnStartConvert_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbOutputFolder.Text))
            {
                MessageBox.Show("Cannot convert!\nOutput Folder does not exist!");
                return;
            }

            foreach (string xmlPath in lbXMLFiles.Items)
            {
                ConvertXML(xmlPath);
            }

            lbXMLFiles.Items.Clear();
            MessageBox.Show("Converted Files into:\n" + tbOutputFolder.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            var result = openFileDialog_XMLFiles.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string fn in openFileDialog_XMLFiles.FileNames)
                {
                    if (ShortMenyooXMLCheck(fn))
                    {
                        if (!lbXMLFiles.Items.Contains(fn))
                        {
                            lbXMLFiles.Items.Add(fn);
                        }
                    }
                }
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbXMLFiles);
            selectedItems = lbXMLFiles.SelectedItems;

            if (lbXMLFiles.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lbXMLFiles.Items.Remove(selectedItems[i]);
                }
            }
        }

        private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbOutputFolder.Text) && Directory.Exists(tbOutputFolder.Text))
            {
                folderBrowserDialog_OutputFolder.InitialDirectory = tbOutputFolder.Text;
            }
            var result = folderBrowserDialog_OutputFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOutputFolder.Text = folderBrowserDialog_OutputFolder.SelectedPath;
            }
        }

        private void Form_Main_Click(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            label1.Focus();
        }

        private void toolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void toolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void lbXMLFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListBoxRightClickedIndex = lbXMLFiles.IndexFromPoint(e.X, e.Y);
            }
        }

        private void removeClickedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListBoxRightClickedIndex >= 0)
            {
                lbXMLFiles.Items.RemoveAt(ListBoxRightClickedIndex);
            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListBoxRightClickedIndex >= 0)
            {
                if (lbXMLFiles.SelectedItems.Contains(lbXMLFiles.Items[ListBoxRightClickedIndex]))
                {
                    lbXMLFiles.SelectedItems.Remove(lbXMLFiles.Items[ListBoxRightClickedIndex]);
                }
                else
                {
                    lbXMLFiles.SelectedItems.Add(lbXMLFiles.Items[ListBoxRightClickedIndex]);
                }
            }
        }
    }
}