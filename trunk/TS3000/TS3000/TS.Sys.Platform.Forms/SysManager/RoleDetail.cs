using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Service;

namespace TS.Sys.Platform.Forms.SysManager
{
    public partial class RoleDetailForm : BaseTypeForm
    {
        private RoleService roleService;
        private RoleForm roleForm;
        private RoleInfo roleInfo;
        private string _referType;
        private Object[] _args;
 

        internal RoleForm RoleListForm
        {
            set { this.roleForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public RoleDetailForm()
        {
            InitializeComponent();
            roleService = new RoleService();
            roleInfo = new RoleInfo();  
            this.ToolBtn=this.toolBtn;
            this.TpControl=this.tpControl;
            this.Info=roleInfo; 
            this.Service=roleService;
            ToolStripButton btnSecu = new ToolStripButton();

            ToolStripItem[] items = new ToolStripItem[1];

            InitForm();
        }

        public RoleDetailForm(String code)
            :this()
        {
            InitForm("new");
            this.cParent.Value = "000000";

        }

        public RoleDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            roleForm.listRefresh(); 
        }


    }
}
