using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.PlatForm.BaseData.Service;

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class AccountDetailForm : BaseTypeForm
    {
        private AccountService acctService;
        private AccountForm _accForm;
        private AccountInfo acctInfo; 
        private string _referType;
        private Object[] _args;


        internal AccountForm AccForm
        {
            set { this._accForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public AccountDetailForm()
        {
            InitializeComponent();
            acctService = new AccountService();
            acctInfo = new AccountInfo();  
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolItem);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", acctInfo); 
            con.Add("Service", acctService);  
            InitForm(con);
        }

        public AccountDetailForm(String code)
            :this()
        {
            InitForm();
            this.cParent.Value = code;

        }

        public AccountDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            _accForm.listRefresh(); 
        }

        
    } 

}
