using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SrtFile
{
    class SrtReader
    {
        public static ListViewItem DefaultItem(int sn)
        {
            ListViewItem.ListViewSubItem sub0 = new ListViewItem.ListViewSubItem();
            sub0.Name = "serialNum";
            sub0.Text = sn.ToString();
            ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem();
            sub1.Name = "showTime";
            sub1.Text = "00:00:00";
            ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem();
            sub2.Name = "hideTime";
            sub2.Text = "00:00:00";
            ListViewItem.ListViewSubItem sub3 = new ListViewItem.ListViewSubItem();
            sub3.Name = "Text";
            sub3.Text = "New Subtitle";
            ListViewItem item = new ListViewItem(new ListViewItem.ListViewSubItem[] { sub0, sub1, sub2, sub3 }, 0);
            return item;
        }
        /// <summary>
        /// Reads a Subtitle File(.srt) to the defined list.
        /// </summary>
        /// <param name="filepath">Subtitle File Path.</param>
        /// <param name="listview">Target ListView.</param>
        /// <param name="redrawColumns">If set to true the target ListView columns will be redrawn as default(SN-Show Time-Hide Time-Text(HTML))</param>
        /// <param name="encoding">Encoding.</param>
        /// <param name="subtitlescount">Will be set to the number of subtitles found in the file.</param>
        /// <param name="recordlength">Will be set to the last subtilte hide time in the file.</param>
        public static void ReadFileToList(string filepath, ref ListViewEx.ListViewEx listview, bool redrawColumns, Encoding encoding, ref string subtitlescount, ref string recordlength, ref string outfilecontent)
        {
            string filecontent = File.ReadAllText(filepath, encoding);
            outfilecontent = filecontent;
            string[] subBlocksStr = Regex.Split(filecontent, "\r\n\r\n");
            List<SubBlock> subBlocksList = new List<SubBlock>();
            if (subBlocksStr.Length > 0)
            {
                foreach (string block in subBlocksStr)
                {
                    if (block != string.Empty)
                        subBlocksList.Add(new SubBlock(block));
                }
            }
            if (redrawColumns)
            {
                listview.Columns.Clear();
                int unit = Convert.ToInt32(listview.Width / 10);
                ColumnHeader serialcol = new ColumnHeader();
                serialcol.Width = unit;
                serialcol.Text = "#";
                ColumnHeader showtcol = new ColumnHeader();
                showtcol.Width = unit * 3;
                showtcol.Text = "Show Time";
                ColumnHeader hidetcol = new ColumnHeader();
                hidetcol.Width = unit * 3;
                hidetcol.Text = "Hide Time";
                ColumnHeader textcol = new ColumnHeader();
                textcol.Width = unit * 3;
                textcol.Text = "Text(HTML)";
                listview.Columns.AddRange(new ColumnHeader[] { serialcol, showtcol, hidetcol, textcol });

            }
            if (subBlocksList.Count > 0)
            {
                int sn = 1;
                foreach (SubBlock block in subBlocksList)
                {
                    ListViewItem.ListViewSubItem sub0 = new ListViewItem.ListViewSubItem();
                    sub0.Name = "serialNum";
                    if (block.IsSerialized)
                    {
                        sub0.Text = block.SerialNumber.ToString();
                    }
                    else
                    {
                        sub0.Text = sn.ToString();
                    }
                    sn++;
                    ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem();
                    sub1.Name = "showTime";
                    sub1.Text = block.ShowTime.ToString();
                    ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem();
                    sub2.Name = "hideTime";
                    sub2.Text = block.HideTime.ToString();
                    ListViewItem.ListViewSubItem sub3 = new ListViewItem.ListViewSubItem();
                    sub3.Name = "Text";
                    sub3.Text = block.Text;
                    ListViewItem item = new ListViewItem(new ListViewItem.ListViewSubItem[] { sub0, sub1, sub2, sub3 }, 0);
                    listview.Items.Add(item);
                }
                subtitlescount = subBlocksList.Count.ToString();
                recordlength = subBlocksList[subBlocksList.Count - 1].HideTime.ToString();
            }
        }
    }
    class SrtWriter
    {
        /// <summary>
        /// Writes ListView content to a SubtitleFile.
        /// </summary>
        /// <param name="filepath">Destination Subtitle File path.</param>
        /// <param name="listview">ListView to write.</param>
        /// <param name="encoding">Encoding.</param>
        /// <param name="error">Will be set to error message if incounted.</param>
        public static void WriteListToFile(string filepath, ListViewEx.ListViewEx listview, Encoding encoding, ref string error)
        {
            StreamWriter fstr = new StreamWriter(filepath, false, encoding);
            try
            {
                int sn = 1;
                foreach (ListViewItem item in listview.Items)
                {

                    SubBlock block = new SubBlock((item.SubItems.Count == 4) ? item.SubItems["serialNum"].Text : sn.ToString(), item.SubItems["showTime"].Text, item.SubItems["hideTime"].Text, item.SubItems["Text"].Text);
                    block.WriteToFile(ref fstr);
                    sn++;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            fstr.Close();
        }
    }
    /// <summary>
    /// SubBlock Container
    /// </summary>
    class SubBlock
    {
        // variables
        double serialNum;
        TimeSpan showtime;
        TimeSpan hidetime;
        string text;
        // constructors
        public SubBlock(string blockStr)
        {
            string[] vals = Regex.Split(blockStr, "\r\n");
            int blockstart = 0;
            if (Double.TryParse(vals[0], out serialNum))
            {
                blockstart = 1;
            }
            else
            {
                serialNum = double.NaN;
            }
            string timeStr = vals[blockstart];
            string[] showhidetimes = Regex.Split(timeStr, " --> ");
            showtime = TimeSpan.Parse(showhidetimes[0].Trim().Replace(",","."));
            hidetime = TimeSpan.Parse(showhidetimes[1].Trim().Replace(",", "."));
            for (int i = blockstart + 1; i < vals.Length; i++)
            {
                text += vals[i] + "\r\n";
            }
            text = text.Trim();
        }
        public SubBlock(string serialn, string showt, string hidet, string btext)
        {
            if (!Double.TryParse(serialn, out serialNum))
            {
                serialNum = double.NaN;
            }
            showtime = TimeSpan.Parse(showt);
            hidetime = TimeSpan.Parse(hidet);
            text = btext;
        }
        // methods
        public void WriteToFile(ref StreamWriter filestream)
        {
            string blockStr = ((IsSerialized) ? serialNum.ToString() + "\r\n" : string.Empty) + GetNormalizedString(showtime) + " --> " + GetNormalizedString(hidetime) + "\r\n" + text + "\r\n";
            filestream.WriteLine(blockStr);
        }
        private string GetNormalizedString(TimeSpan spn)
        {
            return spn.Hours.ToString("00") + ":" + spn.Minutes.ToString("00") + ":" + spn.Seconds.ToString("00") + "," + spn.Milliseconds.ToString("000");
        }
        // public variables
        public double SerialNumber
        {
            get
            {
                return serialNum;
            }
        }
        public TimeSpan ShowTime
        {
            get
            {
                return showtime;
            }
        }
        public TimeSpan HideTime
        {
            get
            {
                return hidetime;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
        }
        public bool IsSerialized
        {
            get
            {
                if (double.IsNaN(serialNum))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
