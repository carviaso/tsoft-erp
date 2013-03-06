using System;
using System.Windows.Forms; 
using TS.Sys.Platform.Forms;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.Forms.SysManager;　

namespace TS_PRS
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
             Application.Run(lg);
             /*CostListForm lg = new CostListForm();
              Application.Run(lg);
            Application.Run(new CustomerDetailForm());*/
        }
    }
}
