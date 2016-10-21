namespace Subtitle_Editor
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frlength = new System.Windows.Forms.Label();
            this.fsubtitles = new System.Windows.Forms.Label();
            this.fsize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.encoding = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.htmlprevMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enlargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToFileContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listview = new ListViewEx.ListViewEx();
            this.timeCont = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delayAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAllDISAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAllTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bold = new System.Windows.Forms.Button();
            this.italic = new System.Windows.Forms.Button();
            this.underline = new System.Windows.Forms.Button();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.newfileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filecontentPrev = new System.Windows.Forms.RichTextBox();
            this.filecontentprevMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enlargeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.htmlprevMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.timeCont.SuspendLayout();
            this.newfileMenu.SuspendLayout();
            this.filecontentprevMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Subtitle Files|*.srt;*.sub|All Files|*.*";
            this.openFileDialog1.Title = "Open Subtitle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frlength);
            this.groupBox1.Controls.Add(this.fsubtitles);
            this.groupBox1.Controls.Add(this.fsize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(631, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info";
            // 
            // frlength
            // 
            this.frlength.AutoSize = true;
            this.frlength.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.frlength.Location = new System.Drawing.Point(71, 60);
            this.frlength.Name = "frlength";
            this.frlength.Size = new System.Drawing.Size(52, 13);
            this.frlength.TabIndex = 1;
            this.frlength.Text = "<Length>";
            // 
            // fsubtitles
            // 
            this.fsubtitles.AutoSize = true;
            this.fsubtitles.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.fsubtitles.Location = new System.Drawing.Point(71, 38);
            this.fsubtitles.Name = "fsubtitles";
            this.fsubtitles.Size = new System.Drawing.Size(59, 13);
            this.fsubtitles.TabIndex = 1;
            this.fsubtitles.Text = "<Subtitles>";
            // 
            // fsize
            // 
            this.fsize.AutoSize = true;
            this.fsize.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.fsize.Location = new System.Drawing.Point(71, 16);
            this.fsize.Name = "fsize";
            this.fsize.Size = new System.Drawing.Size(39, 13);
            this.fsize.TabIndex = 1;
            this.fsize.Text = "<Size>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subtitles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "New Subtitle";
            this.saveFileDialog1.Filter = "Subtitle File|*.srt;*.sub|HTML Preview|*.htm";
            this.saveFileDialog1.Title = "Save Subtitle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.encoding);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(631, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 96);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encoding";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reload File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // encoding
            // 
            this.encoding.FormattingEnabled = true;
            this.encoding.Location = new System.Drawing.Point(9, 40);
            this.encoding.Name = "encoding";
            this.encoding.Size = new System.Drawing.Size(215, 21);
            this.encoding.TabIndex = 0;
            this.encoding.SelectedIndexChanged += new System.EventHandler(this.encoding_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Encoding";
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.htmlprevMenu;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(631, 221);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(230, 117);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // htmlprevMenu
            // 
            this.htmlprevMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enlargeToolStripMenuItem,
            this.updatePreviewToolStripMenuItem,
            this.switchToFileContentToolStripMenuItem});
            this.htmlprevMenu.Name = "contextMenuStrip1";
            this.htmlprevMenu.ShowImageMargin = false;
            this.htmlprevMenu.Size = new System.Drawing.Size(132, 70);
            // 
            // enlargeToolStripMenuItem
            // 
            this.enlargeToolStripMenuItem.Name = "enlargeToolStripMenuItem";
            this.enlargeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.enlargeToolStripMenuItem.Text = "Enlarge";
            this.enlargeToolStripMenuItem.Click += new System.EventHandler(this.enlargeToolStripMenuItem_Click);
            // 
            // updatePreviewToolStripMenuItem
            // 
            this.updatePreviewToolStripMenuItem.Name = "updatePreviewToolStripMenuItem";
            this.updatePreviewToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.updatePreviewToolStripMenuItem.Text = "Update Preview";
            this.updatePreviewToolStripMenuItem.Click += new System.EventHandler(this.updatePreviewToolStripMenuItem_Click);
            // 
            // switchToFileContentToolStripMenuItem
            // 
            this.switchToFileContentToolStripMenuItem.Name = "switchToFileContentToolStripMenuItem";
            this.switchToFileContentToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.switchToFileContentToolStripMenuItem.Text = "File Content";
            this.switchToFileContentToolStripMenuItem.Click += new System.EventHandler(this.switchToFileContentToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add subtitle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(873, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "New Subtitle";
            this.toolStripButton1.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Open Subtitle";
            this.toolStripButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Save File";
            this.toolStripButton3.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Save File As..";
            this.toolStripButton4.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // listview
            // 
            this.listview.AllowColumnReorder = true;
            this.listview.ContextMenuStrip = this.timeCont;
            this.listview.DoubleClickActivation = true;
            this.listview.FullRowSelect = true;
            this.listview.Location = new System.Drawing.Point(12, 29);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(613, 309);
            this.listview.TabIndex = 0;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            this.listview.SubItemClicked += new ListViewEx.SubItemEventHandler(this.listview_SubItemClicked);
            // 
            // timeCont
            // 
            this.timeCont.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delayAllToolStripMenuItem,
            this.editAllDISAPToolStripMenuItem,
            this.editAllTimeToolStripMenuItem});
            this.timeCont.Name = "timeCont";
            this.timeCont.ShowImageMargin = false;
            this.timeCont.Size = new System.Drawing.Size(128, 92);
            // 
            // delayAllToolStripMenuItem
            // 
            this.delayAllToolStripMenuItem.Name = "delayAllToolStripMenuItem";
            this.delayAllToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.delayAllToolStripMenuItem.Text = "Edit all show";
            this.delayAllToolStripMenuItem.Click += new System.EventHandler(this.delayAllToolStripMenuItem_Click);
            // 
            // editAllDISAPToolStripMenuItem
            // 
            this.editAllDISAPToolStripMenuItem.Name = "editAllDISAPToolStripMenuItem";
            this.editAllDISAPToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.editAllDISAPToolStripMenuItem.Text = "Edit all hide";
            this.editAllDISAPToolStripMenuItem.Click += new System.EventHandler(this.editAllDISAPToolStripMenuItem_Click);
            // 
            // editAllTimeToolStripMenuItem
            // 
            this.editAllTimeToolStripMenuItem.Name = "editAllTimeToolStripMenuItem";
            this.editAllTimeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.editAllTimeToolStripMenuItem.Text = "Edit all time";
            this.editAllTimeToolStripMenuItem.Click += new System.EventHandler(this.editAllTimeToolStripMenuItem_Click);
            // 
            // bold
            // 
            this.bold.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.bold.Location = new System.Drawing.Point(101, 2);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(20, 20);
            this.bold.TabIndex = 3;
            this.bold.Text = "B";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.italic.Location = new System.Drawing.Point(123, 2);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(20, 20);
            this.italic.TabIndex = 4;
            this.italic.Text = "I";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // underline
            // 
            this.underline.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.underline.Location = new System.Drawing.Point(145, 2);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(20, 20);
            this.underline.TabIndex = 5;
            this.underline.Text = "U";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(12, 29);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(100, 20);
            this.editTextBox.TabIndex = 1;
            this.editTextBox.Visible = false;
            // 
            // newfileMenu
            // 
            this.newfileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.sUBFileToolStripMenuItem});
            this.newfileMenu.Name = "newfileMenu";
            this.newfileMenu.ShowImageMargin = false;
            this.newfileMenu.ShowItemToolTips = false;
            this.newfileMenu.Size = new System.Drawing.Size(92, 48);
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.nToolStripMenuItem.Text = "SRT File";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // sUBFileToolStripMenuItem
            // 
            this.sUBFileToolStripMenuItem.Name = "sUBFileToolStripMenuItem";
            this.sUBFileToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.sUBFileToolStripMenuItem.Text = "SUB File";
            this.sUBFileToolStripMenuItem.Click += new System.EventHandler(this.sUBFileToolStripMenuItem_Click);
            // 
            // filecontentPrev
            // 
            this.filecontentPrev.ContextMenuStrip = this.filecontentprevMenu;
            this.filecontentPrev.Location = new System.Drawing.Point(631, 221);
            this.filecontentPrev.Name = "filecontentPrev";
            this.filecontentPrev.Size = new System.Drawing.Size(230, 117);
            this.filecontentPrev.TabIndex = 11;
            this.filecontentPrev.Text = "";
            this.filecontentPrev.Visible = false;
            // 
            // filecontentprevMenu
            // 
            this.filecontentprevMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enlargeToolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.hTMLToolStripMenuItem});
            this.filecontentprevMenu.Name = "filecontentprevMenu";
            this.filecontentprevMenu.ShowImageMargin = false;
            this.filecontentprevMenu.ShowItemToolTips = false;
            this.filecontentprevMenu.Size = new System.Drawing.Size(89, 70);
            // 
            // enlargeToolStripMenuItem1
            // 
            this.enlargeToolStripMenuItem1.Name = "enlargeToolStripMenuItem1";
            this.enlargeToolStripMenuItem1.Size = new System.Drawing.Size(88, 22);
            this.enlargeToolStripMenuItem1.Text = "Enlarge";
            this.enlargeToolStripMenuItem1.Click += new System.EventHandler(this.enlargeToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(873, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.filecontentPrev);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "Subtitle Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.htmlprevMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.timeCont.ResumeLayout(false);
            this.newfileMenu.ResumeLayout(false);
            this.filecontentprevMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fsubtitles;
        private System.Windows.Forms.Label fsize;
        private System.Windows.Forms.Label frlength;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox encoding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip htmlprevMenu;
        private System.Windows.Forms.ToolStripMenuItem enlargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePreviewToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private ListViewEx.ListViewEx listview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Button italic;
        private System.Windows.Forms.Button underline;
        private System.Windows.Forms.TextBox editTextBox;
        private System.Windows.Forms.ContextMenuStrip newfileMenu;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBFileToolStripMenuItem;
        private System.Windows.Forms.RichTextBox filecontentPrev;
        private System.Windows.Forms.ContextMenuStrip filecontentprevMenu;
        private System.Windows.Forms.ToolStripMenuItem enlargeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem switchToFileContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip timeCont;
        private System.Windows.Forms.ToolStripMenuItem delayAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAllDISAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAllTimeToolStripMenuItem;
    }
}

