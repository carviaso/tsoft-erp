using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Service;

namespace TS.Sys.Platform.Forms.SysManager
{
    public partial class UserDetailForm : BaseTypeForm
    {
        private UserService userService;
        private UserForm userForm;
        private UserInfo userInfo; 
        private string _referType;
        private Object[] _args;


        internal UserForm UserManForm
        {
            set { this.userForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public UserDetailForm()
        {
            InitializeComponent();

            ToolStripButton btnModifyPwd = new ToolStripButton();
            InitDefinedButton(btnModifyPwd);
            ToolStripItem[] items = new ToolStripItem[] { btnModifyPwd };
            Items = items;
            userService = new UserService();
            userInfo = new UserInfo();  
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolBank);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", userInfo); 
            con.Add("Service", userService);  
            InitForm(con);
        }

        private void InitDefinedButton(ToolStripButton btnModifyPwd)
        {
            // 
            // btnModifyPwd
            // 
            btnModifyPwd.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Modify;
            btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnModifyPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnModifyPwd.Name = "btnModifyPwd";
            btnModifyPwd.Size = new System.Drawing.Size(60, 42);
            btnModifyPwd.Text = "修改密码";
            btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnModifyPwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnModifyPwd.Click += new System.EventHandler(btnModifyPwd_Click);
        }

        public UserDetailForm(String code)
            :this()
        {
            InitForm();
            this.cRole.Value = code;

        }

        public override void Add()
        {
            base.Add();

        } 

        public UserDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
        }

        private void btnInfo_Click()
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();

            Type t = tempAssembly.GetType(_referType);
            object[] args = _args;
            object o = System.Activator.CreateInstance(t, args);

            ((Form)o).WindowState = FormWindowState.Normal;
            ((Form)o).ShowDialog();
        }

        private void ListRefresh()
        {
            userForm.listRefresh(); 
        }

        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            UserModifyPwdForm umf = new UserModifyPwdForm(userInfo);
            umf.ShowDialog();
        }
    }
}
