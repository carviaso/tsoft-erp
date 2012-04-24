using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class DepartmentDetailForm : BaseTypeForm
    {
        private DepartmentService deptService;
        private DepartmentForm deptForm;
        private DepartmentInfo deptInfo; 
        private string _referType;
        private Object[] _args;


        internal DepartmentForm DeptForm
        {
            set { this.deptForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public DepartmentDetailForm()
        {
            InitializeComponent();
            deptService = new DepartmentService();
            deptInfo = new DepartmentInfo();  
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolBtn);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", deptInfo); 
            con.Add("Service", deptService);  
            InitForm(con);
        }

        public DepartmentDetailForm(String code)
            :this()
        {
            InitForm();
            this.cParent.Value = code;

        }

        public DepartmentDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            deptForm.listRefresh(); 
        }

    }
}
