using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.BaseData.Forms
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
            this.ToolBtn = this.toolBtn;
            this.TpControl = this.tpControl;
            this.Info = deptInfo; 
            this.BaseService = deptService;  
            InitForm();
        }

        public DepartmentDetailForm(String code)
            :this()
        {
            InitForm("new");
            this.cParent.Value = code;

        }

        public DepartmentDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
        }


        private void ListRefresh()
        {
            deptForm.listRefresh(); 
        }

    }
}
