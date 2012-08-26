using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class CustomerDetailForm : BaseTypeForm
    {
        private CustomerService custService;
        private CustomerInfo custInfo;
        private CustomerForm custForm;
        private string _referType;
        private Object[] _args;


        internal CustomerForm CustForm
        {
            set { this.custForm = value; }
        }

        internal String cRegionValue
        {
            get { return this.cRegion.Value.ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value) && !value.Equals("000000"))
                { this.cRegion.Value = value; }
            }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public CustomerDetailForm()
        {
            InitializeComponent();
            custService = new CustomerService();
            custInfo = new CustomerInfo();  
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolItem);
            con.Add("TpControl", this.tpControl);
            con.Add("TbControl", this.tbControl);
            con.Add("Info", custInfo); 
            con.Add("Service", custService);  
            InitForm(con);
        }

        /// <summary>
        /// 传入区域编号
        /// </summary>
        /// <param name="code"></param>
        public CustomerDetailForm(String code)
            :this()
        {
            InitForm();
            this.cRegion.Value = code;       

        }

        public CustomerDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            custForm.listRefresh(); 
        }
    
    }
}
