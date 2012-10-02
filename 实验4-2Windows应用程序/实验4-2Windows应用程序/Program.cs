using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 实验4_2Windows应用程序
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
            Application.Run(new Form1());
        }
    }
}
