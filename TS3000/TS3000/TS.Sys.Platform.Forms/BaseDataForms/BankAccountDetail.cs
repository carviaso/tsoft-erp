using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class BankAccountDetailForm : BaseTypeForm
    {
        private BankAcctService bankAcctService;
        private BankAccountForm bankAcctForm;
        private BankAccountInfo bankAcctInfo; 
        private string _referType;
        private Object[] _args;


        internal BankAccountForm BankAcctForm
        {
            set { this.bankAcctForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public BankAccountDetailForm()
        {
            InitializeComponent();
            bankAcctService = new BankAcctService();
            bankAcctInfo = new BankAccountInfo();  
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolBank);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", bankAcctInfo); 
            con.Add("Service", bankAcctService);  
            InitForm(con);
        }

        public BankAccountDetailForm(String code)
            :this()
        {
            InitForm();
            this.cBank.Value = code;

        }

        public BankAccountDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            bankAcctForm.listRefresh(); 
        }


    }
}
