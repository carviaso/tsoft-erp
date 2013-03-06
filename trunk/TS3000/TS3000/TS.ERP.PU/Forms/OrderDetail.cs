using System;
using System.Windows.Forms;
using TS.ERP.PU.Forms;
using TS.ERP.PU.Info;
using TS.ERP.PU.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl;
using System.Collections;
using TS.ERP.Business;

namespace TS.ERP.PU
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
            Hashtable args = new Hashtable();
            args.Add("cMateriaCode", "cCode");
            args.Add("cMateriaName", "cName");
            args.Add("cUnit", "cUnit");
            args.Add("iUnitPrice", "iOutPrice");
            args.Add("iDiscount", "iDiscount");
            new MateriaReferImpl().setGridDataSource(this.cMateriaCode, null, args);
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
            base.SubGrid = this.gridMateriaDetail;
            base.BillType = "PU";
            base.SumGrid = this.gridMateriaDetail; 
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
            this.txtTitle.Text = "采购订单";       
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

        private void gridMateriaDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gridMateriaDetail.CurrentRow != null)
            {
                if (this.gridMateriaDetail.CurrentCell.OwningColumn.Name.Equals("iDiscount") || this.gridMateriaDetail.CurrentCell.OwningColumn.Name.Equals("iNum"))
                {
                    MoneyCaculateService mcService = new MoneyCaculateService();
                    int iDiscount = int.Parse(this.gridMateriaDetail.CurrentRow.Cells["iDiscount"].Value.ToString());
                    int iNum = int.Parse(this.gridMateriaDetail.CurrentRow.Cells["iNum"].Value.ToString());
                    Decimal unitPrice = Decimal.Parse(this.gridMateriaDetail.CurrentRow.Cells["iUnitPrice"].Value.ToString());
                    this.gridMateriaDetail.CurrentRow.Cells["iAmt"].Value = mcService.MateriaMoneySumCaculate(unitPrice, iDiscount, iNum);
                }
            }
        }
 

    }
}
