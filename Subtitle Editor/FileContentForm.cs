using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Subtitle_Editor
{
    public partial class FileContentForm : Form
    {
        public FileContentForm(string content)
        {
            InitializeComponent();
            filecontentBox.Text = content;
        }

        private void FileContentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
