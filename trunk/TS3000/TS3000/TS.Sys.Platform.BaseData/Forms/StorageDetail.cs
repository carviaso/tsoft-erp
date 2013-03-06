using System;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.BaseData.Forms
{
    public partial class StorageDetailForm : BaseTypeForm
    {
        private StorageService storeService;
        private StorageInfo storeInfo;
        private StorageForm storeForm;
        private string _referType;
        private Object[] _args;


        internal StorageForm StoreForm
        {
            set { this.storeForm = value; }
        }

        internal String cRegionValue
        {
            get { return this.cParent.Value.ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value) && !value.Equals("000000"))
                { this.cParent.Value = value; }
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

        public StorageDetailForm()
        {
            InitializeComponent();
            storeService = new StorageService();
            storeInfo = new StorageInfo();  
            this.ToolBtn=this.toolItem;
            this.TpControl=this.tpControl;
            this.TbControl=this.tbControl;
            this.Info=storeInfo; 
            this.BaseService=storeService;  
            InitForm();
        }

        /// <summary>
        /// 传入区域编号
        /// </summary>
        /// <param name="code"></param>
        public StorageDetailForm(String code)
            :this()
        {
            InitForm("new");
            this.cParent.Value = code;       

        }

        public StorageDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            storeForm.listRefresh(); 
        }

        private void cParent_Load(object sender, EventArgs e)
        {

        }
    
    }
}
