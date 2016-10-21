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
    public partial class HTMLPreviewFrm : Form
    {
        public HTMLPreviewFrm(string htmlpath)
        {
            InitializeComponent();
            webBrowser1.Navigate(htmlpath);
        }

        private void HTMLPreviewFrm_Load(object sender, EventArgs e)
        {
            // --
        }
    }
}
