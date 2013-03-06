using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.ERP.FA.Forms;
using TS.ERP.FA.Info;
using TS.ERP.FA.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl;

namespace TS.ERP.FA
{
    public partial class RevenDetailForm : BillTypeForm
    {
        private RevenInfo RevenInfo;
        private RevenSubInfo RevenSubInfo;
        private RevenService RevenService;
        private RevenListForm RevenListForm; 


        internal RevenListForm CtListForm
        {
            set { this.RevenListForm = value; }
        }
        

        public RevenDetailForm()
        {
            this.txtTitle.Text = "其他收入单";
            new CostTypeReferImpl().setGridDataSource(this.cRevenType, null, null);
            InitializeComponent();
            RevenInfo = new RevenInfo();
            RevenSubInfo = new RevenSubInfo();
            RevenService = new RevenService();
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
            base.MainInfo = this.RevenInfo;
            base.SubInfo = this.RevenSubInfo;
            base.BusinessService = this.RevenService;
            base.SubGrid = this.gridMember;
            base.BillType = "FA";
            base.SumGrid = this.gridMember; 
        }

        public RevenDetailForm(String action)
            :this()
        {
            InitForm(action);
          
        }

        public RevenDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
          
        }

        

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        private void ListRefresh()
        {

            if (RevenListForm != null)
            {
                RevenListForm.listRefresh();
            }
        }

        public override void New()
        {
            base.New();
            this.RevenInfo = new RevenInfo();
        }


    }
}
