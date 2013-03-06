using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.BaseData.Forms
{
    public partial class BankAccountDetailForm : BaseTypeForm
    {
        private BankAccountService bankService;
        private BankAccountForm bankForm;
        private BankAccountInfo bankInfo; 
        private string _referType;
        private Object[] _args;


        internal BankAccountForm BkForm
        {
            set { this.bankForm = value; }
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
            bankService = new BankAccountService();
            bankInfo = new BankAccountInfo();  
            Hashtable con = new Hashtable();
            this.ToolBtn=this.toolBankAccount;
            this.TpControl=this.tpControl;
            this.Info=bankInfo; 
            this.BaseService=bankService;  
            InitForm();
        }

        public BankAccountDetailForm(String code)
            :this()
        {
            InitForm("new");
            this.cBank.Value = code;

        }

        public BankAccountDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
        }
        /*
        private void btnInfo_Click()
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();

            Type t = tempAssembly.GetType(_referType);
            object[] args = _args;
            object o = System.Activator.CreateInstance(t, args);

            ((Form)o).WindowState = FormWindowState.Normal;
            ((Form)o).ShowDialog();
        }*/

        private void ListRefresh()
        {
            bankForm.listRefresh(); 
        }


    }
}
