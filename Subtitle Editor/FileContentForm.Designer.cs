namespace Subtitle_Editor
{
    partial class FileContentForm
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
            this.filecontentBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // filecontentBox
            // 
            this.filecontentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filecontentBox.Location = new System.Drawing.Point(0, 0);
            this.filecontentBox.Name = "filecontentBox";
            this.filecontentBox.Size = new System.Drawing.Size(584, 312);
            this.filecontentBox.TabIndex = 0;
            this.filecontentBox.Text = "";
            // 
            // FileContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this.filecontentBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FileContentForm";
            this.Text = "File Content";
            this.Load += new System.EventHandler(this.FileContentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox filecontentBox;
    }
}