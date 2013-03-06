using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.ERP.SA.Forms;
using TS.ERP.SA.Info;
using TS.ERP.SA.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl;

namespace TS.ERP.SA
{
    public partial class OrderDetailForm : BillTypeForm
    {
        private OrderInfo OrderInfo;
        private OrderSubInfo OrderSubInfo;
        private OrderService OrderService;
        private OrderListForm OrderListForm; 


        internal OrderListForm CtListForm
        {
            set { this.OrderListForm = value; }
        }
        

        public OrderDetailForm()
        {
                
            InitializeComponent();
            
            new CostTypeReferImpl().setGridDataSource(this.cMateriaCode, null,null);
            OrderInfo = new OrderInfo();
            OrderSubInfo = new OrderSubInfo();
            OrderService = new OrderService();
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
            base.MainInfo = this.OrderInfo;
            base.SubInfo = this.OrderSubInfo;
            base.BusinessService = this.OrderService;
            base.SubGrid = this.gridMember;
            base.BillType = "SA";
            base.SumGrid = this.gridMember; 
        }

        public OrderDetailForm(String action)
            :this()
        {
            InitForm(action);
          
        }

        public OrderDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            this.txtTitle.Text = "销售订单";       
        }

        

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        private void ListRefresh()
        {

            if (OrderListForm != null)
            {
                OrderListForm.listRefresh();
            }
        }

        public override void New()
        {
            base.New();
            this.OrderInfo = new OrderInfo();
        }

        private void cSettleType_Load(object sender, EventArgs e)
        {

        }


    }
}
