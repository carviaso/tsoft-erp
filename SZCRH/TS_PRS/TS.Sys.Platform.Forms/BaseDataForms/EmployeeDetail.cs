using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class EmployeeDetailForm : BaseTypeForm
    {
        private bool editFlag = false;
        private EmployeeService empService;
        private EmployeeInfo empInfo;
        private EmployeeForm empForm;
        private string _referType;
        private Object[] _args; 

        public EmployeeDetailForm()
        {
            InitializeComponent();
            empService = new EmployeeService();
            empInfo = new EmployeeInfo();
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolBtn);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", empInfo);
            con.Add("Service", empService);
            InitForm(con);
            this.tbControl.TabPages[0].Text = "职员属性";
        }

        internal EmployeeForm EmpForm
        {
            set { this.empForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public EmployeeDetailForm(String code)
            :this()
        {
            InitForm();
            this.cDepartment.Value = code;

        }
        
        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public EmployeeDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            empForm.listRefresh();
        }
    }
}
