namespace Menyoo_XML_to_Rebound_MapMods_JSON
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartConvert = new System.Windows.Forms.Button();
            this.tbOutputFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.openFileDialog_XMLFiles = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_OutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lbXMLFiles = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_xmlListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeClickedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiscord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip_xmlListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartConvert
            // 
            this.btnStartConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartConvert.Location = new System.Drawing.Point(508, 326);
            this.btnStartConvert.Name = "btnStartConvert";
            this.btnStartConvert.Size = new System.Drawing.Size(99, 23);
            this.btnStartConvert.TabIndex = 100;
            this.btnStartConvert.Text = "Start Convert";
            this.btnStartConvert.UseVisualStyleBackColor = true;
            this.btnStartConvert.Click += new System.EventHandler(this.btnStartConvert_Click);
            // 
            // tbOutputFolder
            // 
            this.tbOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputFolder.Location = new System.Drawing.Point(12, 267);
            this.tbOutputFolder.Name = "tbOutputFolder";
            this.tbOutputFolder.Size = new System.Drawing.Size(490, 23);
            this.tbOutputFolder.TabIndex = 40;
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutputFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseOutputFolder.Location = new System.Drawing.Point(508, 267);
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.Size = new System.Drawing.Size(99, 23);
            this.btnBrowseOutputFolder.TabIndex = 50;
            this.btnBrowseOutputFolder.Text = "Browse";
            this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // openFileDialog_XMLFiles
            // 
            this.openFileDialog_XMLFiles.Multiselect = true;
            // 
            // lbXMLFiles
            // 
            this.lbXMLFiles.AllowDrop = true;
            this.lbXMLFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbXMLFiles.ContextMenuStrip = this.contextMenuStrip_xmlListBox;
            this.lbXMLFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbXMLFiles.FormattingEnabled = true;
            this.lbXMLFiles.IntegralHeight = false;
            this.lbXMLFiles.ItemHeight = 15;
            this.lbXMLFiles.Location = new System.Drawing.Point(12, 76);
            this.lbXMLFiles.Name = "lbXMLFiles";
            this.lbXMLFiles.ScrollAlwaysVisible = true;
            this.lbXMLFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbXMLFiles.Size = new System.Drawing.Size(595, 165);
            this.lbXMLFiles.TabIndex = 30;
            this.lbXMLFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbXMLFiles_MouseDown);
            // 
            // contextMenuStrip_xmlListBox
            // 
            this.contextMenuStrip_xmlListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectToolStripMenuItem,
            this.toolStripSeparator2,
            this.removeClickedToolStripMenuItem,
            this.removeSelectedToolStripMenuItem});
            this.contextMenuStrip_xmlListBox.Name = "contextMenuStrip_xmlListBox";
            this.contextMenuStrip_xmlListBox.Size = new System.Drawing.Size(164, 104);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            this.addToolStripMenuItem.MouseLeave += new System.EventHandler(this.toolStripMenuItem_MouseLeave);
            this.addToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem_MouseMove);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.selectToolStripMenuItem.Text = "Select/Deselect";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            this.selectToolStripMenuItem.MouseLeave += new System.EventHandler(this.toolStripMenuItem_MouseLeave);
            this.selectToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem_MouseMove);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // removeClickedToolStripMenuItem
            // 
            this.removeClickedToolStripMenuItem.Name = "removeClickedToolStripMenuItem";
            this.removeClickedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeClickedToolStripMenuItem.Text = "Remove clicked";
            this.removeClickedToolStripMenuItem.Click += new System.EventHandler(this.removeClickedToolStripMenuItem_Click);
            this.removeClickedToolStripMenuItem.MouseLeave += new System.EventHandler(this.toolStripMenuItem_MouseLeave);
            this.removeClickedToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem_MouseMove);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            this.removeSelectedToolStripMenuItem.MouseLeave += new System.EventHandler(this.toolStripMenuItem_MouseLeave);
            this.removeSelectedToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripMenuItem_MouseMove);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(12, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSelected.Location = new System.Drawing.Point(93, 47);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(111, 23);
            this.btnRemoveSelected.TabIndex = 20;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click \"Add\" or Drag & Drop Menyoo XML Files into the List-Box.\r\nDrag & Drop also " +
    "supports Directories recursively.\r\n";
            this.label1.UseMnemonic = false;
            // 
            // lblDiscord
            // 
            this.lblDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiscord.AutoSize = true;
            this.lblDiscord.Location = new System.Drawing.Point(12, 337);
            this.lblDiscord.Name = "lblDiscord";
            this.lblDiscord.Size = new System.Drawing.Size(140, 15);
            this.lblDiscord.TabIndex = 10;
            this.lblDiscord.Text = "My Discord: Steiger#3068";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output Folder:";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(597, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "The Files get saved into the Output Folder with their input Name and override exi" +
    "sting Files with the same name!";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 15);
            this.label4.TabIndex = 101;
            this.label4.Text = "Note: Many Menyoo Objects do not work with Rebound atm!";
            this.label4.UseMnemonic = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiscord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbXMLFiles);
            this.Controls.Add(this.btnBrowseOutputFolder);
            this.Controls.Add(this.tbOutputFolder);
            this.Controls.Add(this.btnStartConvert);
            this.MinimumSize = new System.Drawing.Size(635, 400);
            this.Name = "Form_Main";
            this.Text = "Menyoo Objects XML to Rebound Map Mod JSON";
            this.Click += new System.EventHandler(this.Form_Main_Click);
            this.contextMenuStrip_xmlListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartConvert;
        private TextBox tbOutputFolder;
        private Button btnBrowseOutputFolder;
        private OpenFileDialog openFileDialog_XMLFiles;
        private FolderBrowserDialog folderBrowserDialog_OutputFolder;
        private ListBox lbXMLFiles;
        private Button btnAdd;
        private Button btnRemoveSelected;
        private Label label1;
        private Label lblDiscord;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip_xmlListBox;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem removeClickedToolStripMenuItem;
        private ToolStripMenuItem removeSelectedToolStripMenuItem;
        private Label label4;
    }
}