using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Session;

namespace TS.Sys.Platform.Forms
{
    public partial class LoginForm : Form
    {
        private MainForm _mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(MainForm mainForm):this()
        {
            this._mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm().Show();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(cUser.Text))
            {
                Msg.Show("请输入用户名！");
                return;
            }
            if (String.IsNullOrEmpty(cPassword.Text))
            {
                Msg.Show("请输入密码！");
                return;
            }
            String user = this.cUser.Text;
            ArrayList result = DbSvr.GetDbService().GetListResult("select u.cGUID,u.cName,u.cRole,u.cCode,us.cPassword from Sys_UserSecu us INNER JOIN Sys_User u ON us.cUser = u.cCode where u.cName = '" + user + "'");
            if (result.Count == 0)
            {
                Msg.Show("用户名不存在！");
                return;
            }
            else
            {               

                Hashtable resultInfo = (Hashtable)result[0];
                String pass = this.cPassword.Text;
                if (pass != resultInfo["cPassword"].ToString())
                {
                    Msg.Show("密码不正确！");
                    return;
                }
                this.Hide();

                SetSessionData(user, result, resultInfo);
                UserInfo u = SetUserData(user, resultInfo);
                MainForm mf = new MainForm(this, u);
                mf.Show();
            }
        }

        /// <summary>
        /// 根据登录用户设置用户对象
        /// </summary>
        /// <param name="user"></param>
        /// <param name="resultInfo"></param>
        /// <returns></returns>
        private static UserInfo SetUserData(String user, Hashtable resultInfo)
        {
            UserInfo u = new UserInfo();
            u.cGUID = resultInfo["cGUID"].ToString();
            u.cName = user;
            u.cCode = resultInfo["cCode"].ToString();
            return u;
        }

        /// <summary>
        /// 登录以后根据登录信息设置相应的Session
        /// </summary>
        /// <param name="user"></param>
        /// <param name="result"></param>
        /// <param name="resultInfo"></param>
        private static void SetSessionData(String user, ArrayList result, Hashtable resultInfo)
        {
            UserSession.LoginDate = DateTime.Today;
            UserSession.UserID = resultInfo["cCode"].ToString();
            UserSession.RoleID = resultInfo["cRole"].ToString();
            UserSession.UserName = user;
            Hashtable con = new Hashtable();
            con.Add("cCode", UserSession.RoleID);
            ArrayList roleResult = DbSvr.GetDbService().GetListResult("select cName from Sys_Role where cCode =@cCode", con);
            if (result.Count > 0)
            {
                Hashtable roleInfo = (Hashtable)result[0];
                UserSession.RoleName = roleInfo["cName"].ToString();
            }
        }

        public void ClearLoginInfo()
        {
            this.cUser.Text = null;
            this.cPassword.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
