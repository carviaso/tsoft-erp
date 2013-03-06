using System;
using System.Windows.Forms;
using TS.ERP.FA.Forms;
using TS.ERP.FA.Info;
using TS.ERP.FA.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl;

namespace TS.ERP.FA
{
    public partial class CostDetailForm : BillTypeForm
    {
        private CostInfo costInfo;
        private CostSubInfo costSubInfo;
        private CostService costService;
        private CostListForm costListForm; 


        internal CostListForm CtListForm
        {
            set { this.costListForm = value; }
        }
        

        public CostDetailForm()
        {
                
            InitializeComponent();
            
            new CostTypeReferImpl().setGridDataSource(this.cCostType, null,null);
            costInfo = new CostInfo();
            costSubInfo = new CostSubInfo();
            costService = new CostService();
            InitFormParams();
            InitForm();
            InitBillData();
        }

        /// <summary>
        /// 初始化Form的参数
        /// </summary>
        /// <returns></returns>
        private void InitFormParams()
        { 
            base.ToolBtn = this.toolItem;
            base.TpControl = this.tpControl;
            base.MainInfo = this.costInfo;
            base.SubInfo = this.costSubInfo;
            base.BusinessService = this.costService;
            base.SubGrid = this.gridMember;
            base.BillType = "FA";
            base.SumGrid = this.gridMember; 
        }

        public CostDetailForm(String action)
            :this()
        {
            InitForm(action);
          
        }

        public CostDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex,ds);
        }

        /// <summary>
        /// 初始化单据中的数据
        /// </summary>
        private void InitBillData()
        {
            //初始化单据时间
            this.dDate.Value = DateTime.Today;
            //ss
            this.txtTitle.Text = "费用支出单";       
        }

        

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        private void ListRefresh()
        {

            if (costListForm != null)
            {
                costListForm.listRefresh();
            }
        }

        public override void New()
        {
            base.New();
            this.costInfo = new CostInfo();
        }

        private void cBankDetail_Load(object sender, EventArgs e)
        {

        }


    }
}
