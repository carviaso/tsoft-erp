using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.BaseData.Forms
{
    public partial class BankDetailForm : BaseTypeForm
    {
        private BankService bankService;
        private BankForm bankForm;
        private BankInfo bankInfo; 
        private string _referType;
        private Object[] _args;


        internal BankForm BkForm
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

        public BankDetailForm()
        {
            InitializeComponent();
            bankService = new BankService();
            bankInfo = new BankInfo();  
            this.ToolBtn=this.toolBank;
            this.TpControl=this.tpControl;
            this.Info=bankInfo; 
            this.BaseService=bankService;  
            InitForm();
        }

        public BankDetailForm(String code)
            :this()
        {
            InitForm("new");

        }

        public BankDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
        }
       
        private void ListRefresh()
        {
            bankForm.listRefresh(); 
        }


    }
}
