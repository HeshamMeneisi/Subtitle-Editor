using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace SubFile
{
    class SubReader
    {
        public static void ReadFileToList(string filepath, ref ListViewEx.ListViewEx listview, bool redrawColumns, Encoding encoding, ref string subtitlescount, ref string recordlength, ref string outfilecontent)
        {
            string fileContent = File.ReadAllText(filepath, encoding);
            outfilecontent = fileContent;
            string[] subblocksStr = Regex.Split(fileContent, "\r\n");
            List<SubBlock> subBlocks = new List<SubBlock>();
            foreach (string block in subblocksStr)
            {
                if (block != string.Empty)
                    subBlocks.Add(new SubBlock(block));
            }
            if (redrawColumns)
            {
                listview.Columns.Clear();
                int unit = Convert.ToInt32(listview.Width / 10);
                ColumnHeader showtcol = new ColumnHeader();
                showtcol.Width = unit * 3;
                showtcol.Text = "Show Time";
                ColumnHeader hidetcol = new ColumnHeader();
                hidetcol.Width = unit * 3;
                hidetcol.Text = "Hide Time";
                ColumnHeader textcol = new ColumnHeader();
                textcol.Width = unit * 4;
                textcol.Text = "Text(HTML)";
                listview.Columns.AddRange(new ColumnHeader[] { showtcol, hidetcol, textcol });
            }
            if (subBlocks.Count > 0)
            {
                foreach (SubBlock block in subBlocks)
                {
                    ListViewItem.ListViewSubItem sub0 = new ListViewItem.ListViewSubItem();
                    sub0.Name = "showTime";
                    sub0.Text = block.ShowTime.ToString();
                    ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem();
                    sub1.Name = "hideTime";
                    sub1.Text = block.HideTime.ToString();
                    ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem();
                    sub2.Name = "Text";
                    sub2.Text = block.Text;
                    ListViewItem item = new ListViewItem(new ListViewItem.ListViewSubItem[] { sub0, sub1, sub2 }, 0);
                    listview.Items.Add(item);
                }
                subtitlescount = subBlocks.Count.ToString();
                recordlength = subBlocks[subBlocks.Count - 1].HideTime.ToString();
            }
        }
    }
    class SubWriter
    {
        public static void WriteListToFile(string filepath, ListViewEx.ListViewEx listview, Encoding encoding, ref string error)
        {
            StreamWriter fstr = new StreamWriter(filepath, false, encoding);
            try
            {
                foreach (ListViewItem item in listview.Items)
                {
                    SubBlock block = new SubBlock(item.SubItems["showTime"].Text, item.SubItems["hideTime"].Text, item.SubItems["Text"].Text);
                    block.WriteToFile(ref fstr);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            fstr.Close();
        }
    }
    class SubBlock
    {
        // variables
        TimeSpan showtime;
        TimeSpan hidetime;
        string text;
        // constructors
        public SubBlock(string blockStr)
        {
            // Extracting showtime
            string showtimeStr = blockStr.Substring(blockStr.IndexOf('{') + 1, blockStr.IndexOf('}') - 1);
            blockStr = blockStr.Remove(blockStr.IndexOf('{'), blockStr.IndexOf('}') + 1);
            showtime = TimeSpan.FromSeconds(Convert.ToDouble(showtimeStr.Trim()) / 25);
            // Extracting hidetime
            string hidetimeStr = blockStr.Substring(blockStr.IndexOf('{') + 1, blockStr.IndexOf('}') - 1);
            blockStr = blockStr.Remove(blockStr.IndexOf('{'), blockStr.IndexOf('}') + 1);
            hidetime = TimeSpan.FromSeconds(Convert.ToDouble(hidetimeStr.Trim()) / 25);
            // Applying text
            text = blockStr.Trim();
        }
        public SubBlock(string showt, string hidet, string btext)
        {
            showtime = TimeSpan.Parse(showt);
            hidetime = TimeSpan.Parse(hidet);
            text = btext.Replace("\r\n", "|");
        }
        public void WriteToFile(ref StreamWriter filestream)
        {
            string blockStr = "{" + Convert.ToInt32(showtime.TotalSeconds * 25) + "}{" + Convert.ToInt32(hidetime.TotalSeconds * 25) + "}" + text;
            filestream.WriteLine(blockStr);
        }
        // Public Variables
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
                return text.Replace("|", "\r\n");
            }
        }
    }
}
