﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Subtitle_Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm(arg));
        }
    }
}