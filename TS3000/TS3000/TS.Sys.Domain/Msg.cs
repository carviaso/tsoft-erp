using System;
using System.Windows.Forms;

namespace TS.Sys.Domain
{
    public class Msg
    {
        public static DialogResult Show(String msg)
        {
            return MessageBox.Show(msg, SysConst.msgBoxTitle);
        }

        public static DialogResult Show(String msg, MessageBoxButtons buttons, MessageBoxIcon ico)
        {
            return MessageBox.Show(msg,SysConst.msgBoxTitle,buttons,ico );
        }
    }
}
