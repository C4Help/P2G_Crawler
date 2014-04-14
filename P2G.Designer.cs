namespace P2G_Crawler
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.gridViewInputFile = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadDataGrpBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comBoxCrawlWhat = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblLoadedfile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnBrowseInputFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gridViewResults = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RuntoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crawlingParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInputFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataGrpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataGrpBox.Panel)).BeginInit();
            this.loadDataGrpBox.Panel.SuspendLayout();
            this.loadDataGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comBoxCrawlWhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResults)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 24);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.gridViewInputFile);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.loadDataGrpBox);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.gridViewResults);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1051, 595);
            this.kryptonSplitContainer1.SplitterDistance = 471;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // gridViewInputFile
            // 
            this.gridViewInputFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewInputFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RegNum,
            this.URL});
            this.gridViewInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewInputFile.Location = new System.Drawing.Point(0, 97);
            this.gridViewInputFile.Name = "gridViewInputFile";
            this.gridViewInputFile.Size = new System.Drawing.Size(471, 498);
            this.gridViewInputFile.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 143;
            // 
            // RegNum
            // 
            this.RegNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegNum.HeaderText = "Registration Number";
            this.RegNum.Name = "RegNum";
            // 
            // URL
            // 
            this.URL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            // 
            // loadDataGrpBox
            // 
            this.loadDataGrpBox.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.loadDataGrpBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadDataGrpBox.Location = new System.Drawing.Point(0, 0);
            this.loadDataGrpBox.Name = "loadDataGrpBox";
            // 
            // loadDataGrpBox.Panel
            // 
            this.loadDataGrpBox.Panel.Controls.Add(this.kryptonLabel1);
            this.loadDataGrpBox.Panel.Controls.Add(this.comBoxCrawlWhat);
            this.loadDataGrpBox.Panel.Controls.Add(this.lblLoadedfile);
            this.loadDataGrpBox.Panel.Controls.Add(this.btnBrowseInputFile);
            this.loadDataGrpBox.Size = new System.Drawing.Size(471, 97);
            this.loadDataGrpBox.TabIndex = 0;
            this.loadDataGrpBox.Text = "Load Data";
            this.loadDataGrpBox.Values.Heading = "Load Data";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(255, 17);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Crawl What ?";
            // 
            // comBoxCrawlWhat
            // 
            this.comBoxCrawlWhat.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.comBoxCrawlWhat.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.comBoxCrawlWhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxCrawlWhat.DropDownWidth = 121;
            this.comBoxCrawlWhat.Items.AddRange(new object[] {
            "Social Media",
            "Facebook",
            "Twitter",
            "Linkedin",
            "YouTube",
            "Contact Info",
            "Emails",
            "Phones",
            "Mission Statment",
            "Description"});
            this.comBoxCrawlWhat.Location = new System.Drawing.Point(343, 16);
            this.comBoxCrawlWhat.Name = "comBoxCrawlWhat";
            this.comBoxCrawlWhat.Size = new System.Drawing.Size(121, 21);
            this.comBoxCrawlWhat.TabIndex = 5;
            this.comBoxCrawlWhat.SelectedIndexChanged += new System.EventHandler(this.comBoxCrawlWhat_SelectedIndexChanged);
            // 
            // lblLoadedfile
            // 
            this.lblLoadedfile.Location = new System.Drawing.Point(11, 48);
            this.lblLoadedfile.Name = "lblLoadedfile";
            this.lblLoadedfile.Size = new System.Drawing.Size(98, 20);
            this.lblLoadedfile.TabIndex = 1;
            this.lblLoadedfile.Values.Text = "No File Selected";
            // 
            // btnBrowseInputFile
            // 
            this.btnBrowseInputFile.Location = new System.Drawing.Point(10, 16);
            this.btnBrowseInputFile.Name = "btnBrowseInputFile";
            this.btnBrowseInputFile.Size = new System.Drawing.Size(90, 25);
            this.btnBrowseInputFile.TabIndex = 0;
            this.btnBrowseInputFile.Values.Text = "Browse";
            this.btnBrowseInputFile.Click += new System.EventHandler(this.btnBrowseInputFile_Click);
            // 
            // gridViewResults
            // 
            this.gridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewResults.Location = new System.Drawing.Point(0, 0);
            this.gridViewResults.Name = "gridViewResults";
            this.gridViewResults.Size = new System.Drawing.Size(575, 595);
            this.gridViewResults.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.RuntoolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.browseToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // RuntoolsToolStripMenuItem
            // 
            this.RuntoolsToolStripMenuItem.Name = "RuntoolsToolStripMenuItem";
            this.RuntoolsToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.RuntoolsToolStripMenuItem.Text = "Run";
            this.RuntoolsToolStripMenuItem.Click += new System.EventHandler(this.RuntoolsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crawlingParametersToolStripMenuItem,
            this.outputDirectoryToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "Settings";
            // 
            // crawlingParametersToolStripMenuItem
            // 
            this.crawlingParametersToolStripMenuItem.Name = "crawlingParametersToolStripMenuItem";
            this.crawlingParametersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.crawlingParametersToolStripMenuItem.Text = "Crawling Parameters";
            // 
            // outputDirectoryToolStripMenuItem
            // 
            this.outputDirectoryToolStripMenuItem.Name = "outputDirectoryToolStripMenuItem";
            this.outputDirectoryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.outputDirectoryToolStripMenuItem.Text = "Output Directory";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 619);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "P2G";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInputFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataGrpBox.Panel)).EndInit();
            this.loadDataGrpBox.Panel.ResumeLayout(false);
            this.loadDataGrpBox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataGrpBox)).EndInit();
            this.loadDataGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comBoxCrawlWhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResults)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridViewInputFile;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox loadDataGrpBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLoadedfile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBrowseInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gridViewResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RuntoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comBoxCrawlWhat;
        private System.Windows.Forms.ToolStripMenuItem crawlingParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
    }
}

