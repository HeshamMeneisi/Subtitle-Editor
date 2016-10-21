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
    public partial class inputFrm : Form
    {
        public inputFrm()
        {
            InitializeComponent();
        }
        bool done = false;
        bool canceled = false;
        private void button1_Click(object sender, EventArgs e)
        {
            done = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canceled = true;
        }
        public int GetInput()
        {
            this.Show();
            while (true)
            {
                Application.DoEvents();
                if (done)
                {
                    this.Close();
                    return Convert.ToInt32(numericUpDown1.Value);
                }
                if (canceled)
                {
                    this.Close();
                    return 0;
                }
            }
        }

        private void inputFrm_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
