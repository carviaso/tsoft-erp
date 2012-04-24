using System;
using System.Windows.Forms;
using TS.PRS.MemberMan.Adapter;
using TS.PRS.MemberMan.Business;
using TS.Sys.Domain;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.Forms.SysForms;
using TS.Sys.Platform.Forms.SysManager;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Static;
using TS.Sys.Session;
using System.Threading;
using TS.PRS.MemberMan.Assit;
using TS.Sys.Platform.Forms.MemberMan;

namespace TS.Sys.Platform.Forms
{
    public partial class MainForm : Form
    {
        private int _count = 0;
        private LoginForm _lf;
        private UserInfo _userInfo;
        private ProcessBarForm myProcessBar = null;

        private delegate bool IncreaseHandle(int nValue);

        private IncreaseHandle myIncrease = null;


        

        public void AddChildItem(String name,String text)
        {
            ToolStripButton childForm = new ToolStripButton(); 
            childForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            childForm.Name = name;
            childForm.Text = text;
            childForm.Size = new System.Drawing.Size(107, 22);
            childForm.Click += new System.EventHandler(this.toolStripButton_Click);
             
        }


        public void AddForm()
        {
            _count++;
        }

        public void DelForm()
        {
            _count--;
        }



        public MainForm()
        {

             
            InitializeComponent();
            WelcomeForm welForm = new WelcomeForm(this);
            welForm.MdiParent = this;
            AddForm();
            welForm.Show();

        }

        public MainForm(LoginForm lf, UserInfo userInfo)
            : this()
        {
            this._lf = lf;
            _userInfo = userInfo;
            GetLoginInfo(userInfo);
        }

        private void GetLoginInfo(UserInfo userInfo)
        {
            this.Text = "川润人力资源管理系统";

            this.labelUser.Text = "当前用户：" + UserSession.UserName;


            this.labelRole.Text = "登录角色：" + UserSession.RoleName;

            this.labelLoginDate.Text = "登录时间：" + UserSession.LoginDate.ToShortDateString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;
            
            foreach (Form chform in charr)
                chform.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Form[] charr = this.MdiChildren;

            //for each child form set the window state to Minimized
            foreach (Form chform in charr)
                chform.WindowState = FormWindowState.Minimized;
        }

        private void btnArrHoriz_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void btnArrVert_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void btnCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
             
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(((ToolStripButton)sender).Name))
                {
                    f.Activate();
                    break;
                }
                 
            } 
        }
  
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this._lf.ClearLoginInfo();
            this._lf.Show();
            this.Hide();

        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            UserModifyPwdForm pwf = new UserModifyPwdForm(_userInfo);
            pwf.ShowDialog();
        }

        private void InitMemberTree()
        {
            MemberReommendModual mrModual = MemberReommendModual.GetInstance();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }

        

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSyncMember_Click(object sender, EventArgs e)
        {
            MemberAdapter memAdapter = new MemberAdapter();
            try
            { 
                memAdapter.DoAdapter(); 
                Msg.Show("同步成功！");
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
                LogService.GetInstance().Info("同步失败", "系统管理");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaResult = Msg.Show("是否同步本次的操作数据？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diaResult == DialogResult.OK)
            {
                btnSyncMember_Click(null, null);
            }
        }

        private void 清空业务数据慎用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = Msg.Show("是否要清空所有业务数据？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diaResult == DialogResult.OK)
            {
                new PwdConfirm("all").ShowDialog();
            }
        }

        private void 清除垃圾数据慎用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = Msg.Show("是否要清空垃圾业务数据？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diaResult == DialogResult.OK)
            {
                new PwdConfirm("rabbish").ShowDialog();  
            }
        }

        private void 批量添加测试数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MemberTest().ShowDialog();
        }

        


 
    }
}
