using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Subtitle_Editor
{
    class HTMLWriter
    {
        /// <summary>
        /// Writes the ListView content into an HTML file.
        /// </summary>
        /// <param name="filepath">Destination HTML file path.</param>
        /// <param name="listview">The ListView to write.</param>
        /// <param name="encoding">Encoding.</param>
        /// <param name="error">Will be set to a message if errors were encountered.</param>
        public static void WriteSrtToHtmlFile(string filepath, ListViewEx.ListViewEx listview, Encoding encoding, ref string error)
        {
            StreamWriter fstr = new StreamWriter(filepath, false, encoding);
            try
            {
                fstr.WriteLine("<html><body>\r\n");
                foreach (ListViewItem item in listview.Items)
                {
                    fstr.WriteLine("<font face=\"Tahoma\" color=blue size=2>");
                    if (item.Text != ".")
                    {
                        fstr.WriteLine("<br><b><" + item.SubItems["serialNum"].Text + "></b></br>\r\n");
                    }
                    fstr.WriteLine("<br>[<font face=\"Tahoma\" color=green size=2>" + item.SubItems["showTime"].Text + "</font> --> <font face=\"Tahoma\" color=red size=2>" + item.SubItems["hideTime"].Text + "</font>]</font> " + item.SubItems["Text"].Text + "</br>");
                }
                fstr.WriteLine("</body></html>");
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            fstr.Close();
        }
        public static void WriteSubToHtmlFile(string filepath, ListViewEx.ListViewEx listview, Encoding encoding, ref string error)
        {
            StreamWriter fstr = new StreamWriter(filepath, false, encoding);
            try
            {
                fstr.WriteLine("<html><body>\r\n");
                foreach (ListViewItem item in listview.Items)
                {
                    fstr.WriteLine("<font face=\"Tahoma\" color=blue size=2>");
                    fstr.WriteLine("<br>[<font face=\"Tahoma\" color=green size=2>" + item.SubItems["showTime"].Text + "</font> --> <font face=\"Tahoma\" color=red size=2>" + item.SubItems["hideTime"].Text + "</font>]</font> " + item.SubItems["Text"].Text + "</br>");
                }
                fstr.WriteLine("</body></html>");
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            fstr.Close();
        }
    }
}
