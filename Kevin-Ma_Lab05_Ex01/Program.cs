﻿using System;
using System.Windows.Forms;

namespace Kevin_Ma_Lab05_Ex01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GenericLinearSearchMethodTestForm());
        }
    }
}
