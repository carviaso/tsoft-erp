using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.ERP.ST.Forms;
using TS.ERP.ST.Info;
using TS.ERP.ST.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl;

namespace TS.ERP.ST
{
    public partial class SaOutDetailForm : BillTypeForm
    {
        private SaOutInfo SaOutInfo;
        private SaOutSubInfo SaOutSubInfo;
        private SaOutService SaOutService;
        private SaOutListForm SaOutListForm; 


        internal SaOutListForm CtListForm
        {
            set { this.SaOutListForm = value; }
        }
        

        public SaOutDetailForm()
        {
                
            InitializeComponent();
            
            new CostTypeReferImpl().setGridDataSource(this.cSaOutType, null,null);
            SaOutInfo = new SaOutInfo();
            SaOutSubInfo = new SaOutSubInfo();
            SaOutService = new SaOutService();
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
            base.MainInfo = this.SaOutInfo;
            base.SubInfo = this.SaOutSubInfo;
            base.BusinessService = this.SaOutService;
            base.SubGrid = this.gridMember;
            base.BillType = "ST";
            base.SumGrid = this.gridMember; 
        }

        public SaOutDetailForm(String action)
            :this()
        {
            InitForm(action);
          
        }

        public SaOutDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            this.txtTitle.Text = "销售出库单";       
        }

        

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        private void ListRefresh()
        {

            if (SaOutListForm != null)
            {
                SaOutListForm.listRefresh();
            }
        }

        public override void New()
        {
            base.New();
            this.SaOutInfo = new SaOutInfo();
        }


    }
}
