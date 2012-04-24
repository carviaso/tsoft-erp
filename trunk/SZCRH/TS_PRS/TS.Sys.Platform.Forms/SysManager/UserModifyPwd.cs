using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Service;

namespace TS.Sys.Platform.Forms.SysManager
{
    public partial class UserModifyPwdForm : Form
    {
        private UserInfo _userInfo;
        private UserService _userService;
        public UserModifyPwdForm()
        {
            InitializeComponent();
        }

        public UserModifyPwdForm(UserInfo userInfo):this()
        {
            _userService = new UserService();
            _userInfo = userInfo;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (newPwd.Text != newPwd2.Text)
            {
                Msg.Show("两次密码输入不一致，请重新输入");
                ClearPwd();
                return;
            }
            try
            {
                _userService.ModifyPwd(_userInfo, oldPwd.Text, newPwd.Text);
                Msg.Show("密码已修改！");
                this.Close();
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void ClearPwd()
        {
            oldPwd.Text = "";
            newPwd.Text = "";
            newPwd2.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
