namespace Notepad
{
    partial class Notepad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.iSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.iRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.iCut = new System.Windows.Forms.ToolStripMenuItem();
            this.iCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.iPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.iDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iFont = new System.Windows.Forms.ToolStripMenuItem();
            this.iFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.iWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZoomMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.iZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.iZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.iDefaultZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.iStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.iAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.iStatusMenu = new System.Windows.Forms.StatusStrip();
            this.iStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.iStatusMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.iOpen,
            this.iSave,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.iExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Enabled = false;
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            // 
            // iOpen
            // 
            this.iOpen.Name = "iOpen";
            this.iOpen.Size = new System.Drawing.Size(145, 22);
            this.iOpen.Text = "Open...";
            this.iOpen.Click += new System.EventHandler(this.iOpen_Click);
            // 
            // iSave
            // 
            this.iSave.Name = "iSave";
            this.iSave.Size = new System.Drawing.Size(145, 22);
            this.iSave.Text = "&Save";
            this.iSave.Click += new System.EventHandler(this.iSave_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // iExit
            // 
            this.iExit.Name = "iExit";
            this.iExit.Size = new System.Drawing.Size(145, 22);
            this.iExit.Text = "&Exit";
            this.iExit.Click += new System.EventHandler(this.iExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iUndo,
            this.iRedo,
            this.toolStripSeparator2,
            this.iSelectAll,
            this.toolStripSeparator3,
            this.iCut,
            this.iCopy,
            this.iPaste,
            this.iDelete});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // iUndo
            // 
            this.iUndo.Name = "iUndo";
            this.iUndo.Size = new System.Drawing.Size(122, 22);
            this.iUndo.Text = "U&ndo";
            this.iUndo.Click += new System.EventHandler(this.iUndo_Click);
            // 
            // iRedo
            // 
            this.iRedo.Name = "iRedo";
            this.iRedo.Size = new System.Drawing.Size(122, 22);
            this.iRedo.Text = "&Redo";
            this.iRedo.Click += new System.EventHandler(this.iRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // iSelectAll
            // 
            this.iSelectAll.Name = "iSelectAll";
            this.iSelectAll.Size = new System.Drawing.Size(122, 22);
            this.iSelectAll.Text = "Select &All";
            this.iSelectAll.Click += new System.EventHandler(this.iSelectAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // iCut
            // 
            this.iCut.Name = "iCut";
            this.iCut.Size = new System.Drawing.Size(122, 22);
            this.iCut.Text = "C&ut";
            this.iCut.Click += new System.EventHandler(this.iCut_Click);
            // 
            // iCopy
            // 
            this.iCopy.Name = "iCopy";
            this.iCopy.Size = new System.Drawing.Size(122, 22);
            this.iCopy.Text = "&Copy";
            this.iCopy.Click += new System.EventHandler(this.iCopy_Click);
            // 
            // iPaste
            // 
            this.iPaste.Name = "iPaste";
            this.iPaste.Size = new System.Drawing.Size(122, 22);
            this.iPaste.Text = "&Paste";
            this.iPaste.Click += new System.EventHandler(this.iPaste_Click);
            // 
            // iDelete
            // 
            this.iDelete.Name = "iDelete";
            this.iDelete.Size = new System.Drawing.Size(122, 22);
            this.iDelete.Text = "&Delete";
            this.iDelete.Click += new System.EventHandler(this.iDelete_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iFont,
            this.iFontColor,
            this.toolStripSeparator1,
            this.iWordWrap});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // iFont
            // 
            this.iFont.Name = "iFont";
            this.iFont.Size = new System.Drawing.Size(139, 22);
            this.iFont.Text = "&Font...";
            this.iFont.Click += new System.EventHandler(this.iFont_Click);
            // 
            // iFontColor
            // 
            this.iFontColor.Name = "iFontColor";
            this.iFontColor.Size = new System.Drawing.Size(139, 22);
            this.iFontColor.Text = "Font &Color...";
            this.iFontColor.Click += new System.EventHandler(this.iFontColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // iWordWrap
            // 
            this.iWordWrap.Checked = true;
            this.iWordWrap.CheckOnClick = true;
            this.iWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iWordWrap.Name = "iWordWrap";
            this.iWordWrap.Size = new System.Drawing.Size(139, 22);
            this.iWordWrap.Text = "&Word Wrap";
            this.iWordWrap.Click += new System.EventHandler(this.iWordWrap_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iZoomMenu,
            this.iStatusBar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // iZoomMenu
            // 
            this.iZoomMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iZoomIn,
            this.iZoomOut,
            this.iDefaultZoom});
            this.iZoomMenu.Name = "iZoomMenu";
            this.iZoomMenu.Size = new System.Drawing.Size(126, 22);
            this.iZoomMenu.Text = "&Zoom";
            // 
            // iZoomIn
            // 
            this.iZoomIn.Name = "iZoomIn";
            this.iZoomIn.Size = new System.Drawing.Size(169, 22);
            this.iZoomIn.Text = "Zoom &In";
            this.iZoomIn.Click += new System.EventHandler(this.iZoomIn_Click);
            // 
            // iZoomOut
            // 
            this.iZoomOut.Name = "iZoomOut";
            this.iZoomOut.Size = new System.Drawing.Size(169, 22);
            this.iZoomOut.Text = "Zoom &Out";
            this.iZoomOut.Click += new System.EventHandler(this.iZoomOut_Click);
            // 
            // iDefaultZoom
            // 
            this.iDefaultZoom.Name = "iDefaultZoom";
            this.iDefaultZoom.Size = new System.Drawing.Size(169, 22);
            this.iDefaultZoom.Text = "&Restore To Default";
            this.iDefaultZoom.Click += new System.EventHandler(this.iDefaultZoom_Click);
            // 
            // iStatusBar
            // 
            this.iStatusBar.Checked = true;
            this.iStatusBar.CheckOnClick = true;
            this.iStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iStatusBar.Name = "iStatusBar";
            this.iStatusBar.Size = new System.Drawing.Size(126, 22);
            this.iStatusBar.Text = "&Status Bar";
            this.iStatusBar.Click += new System.EventHandler(this.iStatusBar_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iGithub,
            this.iAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // iGithub
            // 
            this.iGithub.Name = "iGithub";
            this.iGithub.Size = new System.Drawing.Size(139, 22);
            this.iGithub.Text = "&Github Page";
            this.iGithub.Click += new System.EventHandler(this.iGithub_Click);
            // 
            // iAbout
            // 
            this.iAbout.Name = "iAbout";
            this.iAbout.Size = new System.Drawing.Size(139, 22);
            this.iAbout.Text = "&About";
            this.iAbout.Click += new System.EventHandler(this.iAbout_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // iStatusMenu
            // 
            this.iStatusMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iStatusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iStatusLabel});
            this.iStatusMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.iStatusMenu.Location = new System.Drawing.Point(0, 430);
            this.iStatusMenu.Name = "iStatusMenu";
            this.iStatusMenu.Size = new System.Drawing.Size(800, 20);
            this.iStatusMenu.TabIndex = 2;
            this.iStatusMenu.Text = "statusStrip1";
            // 
            // iStatusLabel
            // 
            this.iStatusLabel.Name = "iStatusLabel";
            this.iStatusLabel.Size = new System.Drawing.Size(53, 15);
            this.iStatusLabel.Text = "{STATUS}";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // noteBox
            // 
            this.noteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.noteBox.Location = new System.Drawing.Point(0, 24);
            this.noteBox.Name = "noteBox";
            this.noteBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.noteBox.Size = new System.Drawing.Size(800, 406);
            this.noteBox.TabIndex = 4;
            this.noteBox.Text = "";
            this.noteBox.SelectionChanged += new System.EventHandler(this.noteBox_SelectionChanged);
            this.noteBox.TextChanged += new System.EventHandler(this.noteBox_TextChanged);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.iStatusMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.iStatusMenu.ResumeLayout(false);
            this.iStatusMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOpen;
        private System.Windows.Forms.ToolStripMenuItem iSave;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iUndo;
        private System.Windows.Forms.ToolStripMenuItem iRedo;
        private System.Windows.Forms.ToolStripMenuItem iCut;
        private System.Windows.Forms.ToolStripMenuItem iCopy;
        private System.Windows.Forms.ToolStripMenuItem iPaste;
        private System.Windows.Forms.ToolStripMenuItem iDelete;
        private System.Windows.Forms.ToolStripMenuItem iSelectAll;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iWordWrap;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZoomMenu;
        private System.Windows.Forms.ToolStripMenuItem iZoomIn;
        private System.Windows.Forms.ToolStripMenuItem iStatusBar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iAbout;
        private System.Windows.Forms.ToolStripMenuItem iZoomOut;
        private System.Windows.Forms.ToolStripMenuItem iDefaultZoom;
        private System.Windows.Forms.ToolStripMenuItem iGithub;
        private System.Windows.Forms.ToolStripMenuItem iFont;
        private System.Windows.Forms.ToolStripMenuItem iFontColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip iStatusMenu;
        private System.Windows.Forms.ToolStripStatusLabel iStatusLabel;
        private System.Windows.Forms.RichTextBox noteBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

