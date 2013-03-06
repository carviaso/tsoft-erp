using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;
using System.Reflection;

namespace TS.Sys.Platform.BaseData.Forms
{
    public partial class SupplyDetailForm : BaseTypeForm
    {
        private SupplyService spService;
        private SupplyForm _spForm;
        private SupplyInfo supInfo;
        private string _referType;
        private Object[] _args;


        public SupplyDetailForm()
        {
            InitializeComponent();
            spService = new SupplyService();
            supInfo = new SupplyInfo();
            Hashtable con = new Hashtable();
            this.ToolBtn = this.toolItem;
            this.TpControl = this.tpControl;
            this.TbControl = this.tbControl;
            this.BaseInfo = this.supInfo;
            this.BaseService = this.spService; 
            InitForm(); 
 
        }

         

        public String cRegionValue
        {
            get { return this.cRegion.Value.ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value) && !value.Equals("000000"))
                { this.cRegion.Value = value; }
            }
        }

        internal SupplyForm SpForm
        {
            set { this._spForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public SupplyDetailForm(String code)
            :this()
        {
            InitForm("new");
            this.cRegionValue = code;

        }
        
        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public SupplyDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
        }

        private void ListRefresh()
        {
            _spForm.listRefresh();
        }
 
       
  
    }
}
