using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SrtFile;
using SubFile;
using System.Drawing;

namespace Subtitle_Editor
{
    public partial class MainFrm : Form
    {
        public MainFrm(string[] arg)
        {
            if (arg.Length > 0)
            {
                if(File.Exists(arg[0]))
                {
                    OpenFile(arg[0]);
                }
            }
            InitializeComponent();
        }
        public enum Filetype { SRT, SUB, None };
        public Filetype currentfiletype = Filetype.None;
        public Encoding mEncoding = ASCIIEncoding.Default;
        public string currentfilepath = null;
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newfileMenu.Show(toolStrip1, new Point(0, toolStripButton1.Height));
        }
        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // New Srt
            string p = Environment.GetEnvironmentVariable("TEMP") + "\\NewSubtitleFile.srt";
            StreamWriter stw = new StreamWriter(p);
            stw.WriteLine("1\r\n00:00:00 --> 00:00:00\r\n<i>Using HTML Code Is Allowed.</i>\r\n\r\n2\r\n00:00:00 --> 00:00:00\r\nNew Subtitle");
            stw.Close();
            if (encoding.Items.Contains(encoding.Text))
            {
                currentfilepath = null;
                string subt = string.Empty;
                string frl = string.Empty;
                string content = string.Empty;
                listview.Items.Clear();
                SrtReader.ReadFileToList(p, ref listview, true, ASCIIEncoding.GetEncoding(encoding.Text), ref subt, ref frl,ref content);
                FileInfo inf = new FileInfo(p);
                fsize.Text = inf.Length / 1024 + "KB";
                fsubtitles.Text = subt;
                frlength.Text = (frl.LastIndexOf('.') > 0) ? frl.Remove(frl.LastIndexOf('.')) : frl;
                p = Environment.GetEnvironmentVariable("TEMP") + "\\setemphtml.htm";
                string error = null;
                HTMLWriter.WriteSrtToHtmlFile(p, listview, mEncoding, ref error);
                if (error == null)
                    webBrowser1.Navigate(p);
                else
                    MessageBox.Show(error, "HTMLWriter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filecontentPrev.Text = content;
                currentfiletype = Filetype.SRT;
            }
            else
            {
                MessageBox.Show("Invalid Encoding!");
            }
        }

        private void sUBFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // New Sub
            string p = Environment.GetEnvironmentVariable("TEMP") + "\\NewSubtitleFile.srt";
            StreamWriter stw = new StreamWriter(p);
            stw.WriteLine("{0}{0}<i>Using HTML Code Is Allowed.</i>\r\n{0}{0}New Subtitle");
            stw.Close();
            if (encoding.Items.Contains(encoding.Text))
            {
                currentfilepath = null;
                string subt = string.Empty;
                string frl = string.Empty;
                string content = string.Empty;
                listview.Items.Clear();
                SubReader.ReadFileToList(p, ref listview, true, ASCIIEncoding.GetEncoding(encoding.Text), ref subt, ref frl, ref content);
                FileInfo inf = new FileInfo(p);
                fsize.Text = inf.Length / 1024 + "KB";
                fsubtitles.Text = subt;
                frlength.Text = (frl.LastIndexOf('.') > 0) ? frl.Remove(frl.LastIndexOf('.')) : frl;
                p = Environment.GetEnvironmentVariable("TEMP") + "\\setemphtml.htm";
                string error = null;
                HTMLWriter.WriteSubToHtmlFile(p, listview, mEncoding, ref error);
                if (error == null)
                    webBrowser1.Navigate(p);
                else
                    MessageBox.Show(error, "HTMLWriter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filecontentPrev.Text = content;
                currentfiletype = Filetype.SUB;
            }
            else
            {
                MessageBox.Show("Invalid Encoding!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog1.FileName);
            }
        }

        private void OpenFile(string filename)
        {
            if (encoding.Items.Contains(encoding.Text))
            {
                currentfilepath = filename;
                string subt = string.Empty;
                string frl = string.Empty;
                string content = string.Empty;
                listview.Items.Clear();
                if (Path.GetExtension(currentfilepath).ToLower() == ".srt")
                {
                    SrtReader.ReadFileToList(currentfilepath, ref listview, true, ASCIIEncoding.GetEncoding(encoding.Text), ref subt, ref frl, ref content);
                    // html preview
                    string p = Environment.GetEnvironmentVariable("TEMP") + "\\setemphtml.htm";
                    string error = null;
                    HTMLWriter.WriteSrtToHtmlFile(p, listview, mEncoding, ref error);
                    if (error == null)
                        webBrowser1.Navigate(p);
                    else
                        MessageBox.Show(error, "HTMLWriter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentfiletype = Filetype.SRT;
                }
                else if (Path.GetExtension(currentfilepath).ToLower() == ".sub")
                {
                    SubReader.ReadFileToList(currentfilepath, ref listview, true, ASCIIEncoding.GetEncoding(encoding.Text), ref subt, ref frl, ref content);
                    // html preview
                    string p = Environment.GetEnvironmentVariable("TEMP") + "\\setemphtml.htm";
                    string error = null;
                    HTMLWriter.WriteSubToHtmlFile(p, listview, mEncoding, ref error);
                    if (error == null)
                        webBrowser1.Navigate(p);
                    else
                        MessageBox.Show(error, "HTMLWriter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentfiletype = Filetype.SUB;
                }
                else
                {
                    MessageBox.Show("Invalid file type.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // grab file info
                FileInfo inf = new FileInfo(currentfilepath);
                fsize.Text = inf.Length / 1024 + "KB";
                fsubtitles.Text = subt;
                frlength.Text = (frl.LastIndexOf('.') > 0) ? frl.Remove(frl.LastIndexOf('.')) : frl;
                filecontentPrev.Text = content;
            }
            else
            {
                MessageBox.Show("Invalid Encoding!");
            }
        }
        private void listview_SubItemClicked(object sender, ListViewEx.SubItemEventArgs e)
        {
            if (listview.SelectedItems.Count > 0)
            {
                listview.StartEditing(editTextBox, e.Item, e.SubItem);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview.Items.Count > 0 && currentfilepath != null && File.Exists(currentfilepath))
            {
                string error = null;
                if (Path.GetExtension(currentfilepath).ToLower() == ".srt")
                    SrtWriter.WriteListToFile(currentfilepath, listview, mEncoding, ref error);
                else if (Path.GetExtension(currentfilepath).ToLower() == ".sub")
                    SubWriter.WriteListToFile(currentfilepath, listview, mEncoding, ref error);
                if (error != null)
                {
                    MessageBox.Show(error);
                }
            }
            if (currentfilepath == null)
            {
                saveAsToolStripMenuItem_Click(this, EventArgs.Empty);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview.Items.Count > 0)
            {
                if (currentfilepath != null)
                    saveFileDialog1.FileName = Path.GetFileName(currentfilepath);
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string error = null;
                    if (Path.GetExtension(saveFileDialog1.FileName).ToLower() == ".htm")
                    {
                        if (currentfiletype == Filetype.SRT)
                            HTMLWriter.WriteSrtToHtmlFile(saveFileDialog1.FileName, listview, mEncoding, ref error);
                        else if (currentfiletype == Filetype.SUB)
                            HTMLWriter.WriteSubToHtmlFile(saveFileDialog1.FileName, listview, mEncoding, ref error);
                    }
                    else if (Path.GetExtension(saveFileDialog1.FileName).ToLower() == ".srt")
                    {
                        SrtWriter.WriteListToFile(saveFileDialog1.FileName, listview, mEncoding, ref error);
                        currentfilepath = saveFileDialog1.FileName;
                    }
                    else if (Path.GetExtension(saveFileDialog1.FileName).ToLower() == ".sub")
                    {
                        SubWriter.WriteListToFile(saveFileDialog1.FileName, listview, mEncoding, ref error);
                        currentfilepath = saveFileDialog1.FileName;
                    }
                    if (error != null)
                    {
                        MessageBox.Show(error);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EncodingInfo enc in ASCIIEncoding.GetEncodings())
            {
                encoding.Items.Add(enc.Name);
            }
            encoding.Text = ASCIIEncoding.Default.WebName;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentfilepath != null)
            {
                if (encoding.Items.Contains(encoding.Text))
                {
                    string subt = string.Empty;
                    string frl = string.Empty;
                    string content = string.Empty;
                    listview.Items.Clear();
                    SrtReader.ReadFileToList(currentfilepath, ref listview, true, ASCIIEncoding.GetEncoding(encoding.Text), ref subt, ref frl, ref content);
                    FileInfo inf = new FileInfo(currentfilepath);
                    fsize.Text = inf.Length / 1024 + "KB";
                    fsubtitles.Text = subt;
                    frlength.Text = frlength.Text = (frl.LastIndexOf('.') > 0) ? frl.Remove(frl.LastIndexOf('.')) : frl;
                    // proto
                    string p = Environment.GetEnvironmentVariable("TEMP") + "\\setemphtml.htm";
                    string error = null;
                    HTMLWriter.WriteSrtToHtmlFile(p, listview, mEncoding, ref error);
                    if (error == null)
                        webBrowser1.Navigate(p);
                }
                else
                {
                    MessageBox.Show("Invalid Encoding!");
                }
            }
            else
            {
                MessageBox.Show("There's no file to reload!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void encoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (encoding.Items.Contains(encoding.Text))
            {
                mEncoding = ASCIIEncoding.GetEncoding(encoding.Text);
            }
        }

        private void enlargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HTMLPreviewFrm frm = new HTMLPreviewFrm(webBrowser1.Url.ToString());
            frm.ShowDialog(this);
        }

        private void updatePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string p = Environment.GetEnvironmentVariable("TEMP") + "\\setemphtml.htm";
            File.Delete(p);
            string error = null;
            if (currentfiletype == Filetype.SRT)
                HTMLWriter.WriteSrtToHtmlFile(p, listview, mEncoding, ref error);
            else if (currentfiletype == Filetype.SUB)
                HTMLWriter.WriteSubToHtmlFile(p, listview, mEncoding, ref error);
            if (error == null)
            {
                if (File.Exists(p))
                    webBrowser1.Navigate(p);
            }
            else
                MessageBox.Show(error, "HTMLWriter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listview.Columns.Count == 4)
            {
                listview.Items.Add(SrtReader.DefaultItem(listview.Items.Count + 1));
            }
            else
            {
                MessageBox.Show("Please creat or open a file.");
            }
        }

        private void bold_Click(object sender, EventArgs e)
        {
            if (listview.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listview.SelectedItems)
                {
                    if (!item.SubItems["Text"].Text.Contains("<b>") && !item.SubItems["Text"].Text.Contains("</b>"))
                        item.SubItems["Text"].Text = "<b>" + item.SubItems["Text"].Text + "</b>";
                }
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            if (listview.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listview.SelectedItems)
                {
                    if (!item.SubItems["Text"].Text.Contains("<i>") && !item.SubItems["Text"].Text.Contains("</i>"))
                        item.SubItems["Text"].Text = "<i>" + item.SubItems["Text"].Text + "</i>";
                }
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            if (listview.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listview.SelectedItems)
                {
                    if (!item.SubItems["Text"].Text.Contains("<u>") && !item.SubItems["Text"].Text.Contains("</u>"))
                        item.SubItems["Text"].Text = "<u>" + item.SubItems["Text"].Text + "</u>";
                }
            }
        }

        private void switchToFileContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filecontentPrev.Visible = true;
            webBrowser1.Visible = false;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            filecontentPrev.Visible = false;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string p = Environment.GetEnvironmentVariable("TEMP") + "\\setempfile.tmp";
            File.Delete(p);
            string error = null;
            if (currentfiletype == Filetype.SRT)
                SrtWriter.WriteListToFile(p, listview, mEncoding, ref error);
            else if (currentfiletype == Filetype.SUB)
                SubWriter.WriteListToFile(p, listview, mEncoding, ref error);
            if (error == null)
            {
                if (File.Exists(p))
                    filecontentPrev.Text = File.ReadAllText(p, mEncoding);
            }
            else
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void enlargeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileContentForm form = new FileContentForm(filecontentPrev.Text);
            form.ShowDialog(this);
        }

        private void delayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFrm frm = new inputFrm();
            int inp = frm.GetInput();
            if (inp != 0)
            {
                foreach (ListViewItem item in listview.Items)
                {
                    TimeSpan sp = TimeSpan.Parse(item.SubItems["showTime"].Text);
                    sp = sp.Add(new TimeSpan(inp * 10000));
                    item.SubItems["showTime"].Text = sp.ToString();
                }
            }
        }

        private void editAllDISAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFrm frm = new inputFrm();
            int inp = frm.GetInput();
            if (inp != 0)
            {
                foreach (ListViewItem item in listview.Items)
                {
                    TimeSpan sp = TimeSpan.Parse(item.SubItems["hideTime"].Text);
                    sp = sp.Add(new TimeSpan(inp * 10000));
                    item.SubItems["hideTime"].Text = sp.ToString();
                }
            }
        }

        private void editAllTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputFrm frm = new inputFrm();
            int inp = frm.GetInput();
            if (inp != 0)
            {
                foreach (ListViewItem item in listview.Items)
                {
                    TimeSpan sp = TimeSpan.Parse(item.SubItems["showTime"].Text);
                    sp = sp.Add(new TimeSpan(inp * 10000));
                    item.SubItems["showTime"].Text = sp.ToString();
                }
                foreach (ListViewItem item in listview.Items)
                {
                    TimeSpan sp = TimeSpan.Parse(item.SubItems["hideTime"].Text);
                    sp = sp.Add(new TimeSpan(inp * 10000));
                    item.SubItems["hideTime"].Text = sp.ToString();
                }
            }
        }
    }
}
