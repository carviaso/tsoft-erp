using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TS.Sys.Platform.Forms;

namespace TS3000
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm lg = new LoginForm();
            lg.StartPosition = FormStartPosition.CenterScreen;
            //Application.Run(new Form1());
            Application.Run(lg);
        }
    }
}
