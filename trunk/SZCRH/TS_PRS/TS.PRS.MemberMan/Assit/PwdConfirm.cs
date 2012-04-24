using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Sys.Domain;

namespace TS.PRS.MemberMan.Assit
{
    public partial class PwdConfirm : Form
    {
        private string flag;
        public PwdConfirm()
        {
            InitializeComponent();
        }

        public PwdConfirm(String c):this()
        {
            this.flag = c;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals("111111"))
            {
                if (flag.Equals("all"))
                {
                    TSoftAssit.ClearAllData();
                    Msg.Show("业务数据已清空");
                }
                else
                {
                    TSoftAssit.ClearRabbishData();
                    Msg.Show("垃圾数据已整理完毕");
                }
                this.Close();
            }
            else
            {
                this.textBox1.Text = null;
                Msg.Show("密码错误，请重新输入！");
            }
        }
    }
}
