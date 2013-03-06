using System;
using System.Windows.Forms;
using TS.ERP.ST.Forms;
using TS.ERP.ST.Info;
using TS.ERP.ST.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl;
using System.Collections;
using TS.ERP.Business;

namespace TS.ERP.ST
{
    public partial class PuInDetailForm : BillTypeForm
    {
        private PuInInfo PuInInfo;
        private PuInSubInfo PuInSubInfo;
        private PuInService PuInService;
        private PuInListForm PuInListForm;
        private int _rownum;



        internal PuInListForm CtListForm
        {
            set { this.PuInListForm = value; }
        }
        

        public PuInDetailForm()
        {
                
            InitializeComponent();
            Hashtable args = new Hashtable();
            args.Add("cMateriaCode", "cCode");
            args.Add("cMateriaName", "cName");
            args.Add("cUnit", "cUnit");
            args.Add("iUnitPrice", "iOutPrice");
            args.Add("iDiscount", "iDiscount");
            new MateriaReferImpl().setGridDataSource(this.cMateriaCode, null, args);
            PuInInfo = new PuInInfo();
            PuInSubInfo = new PuInSubInfo();
            PuInService = new PuInService();
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
            base.MainInfo = this.PuInInfo;
            base.SubInfo = this.PuInSubInfo;
            base.BusinessService = this.PuInService;
            base.SubGrid = this.gridMateriaDetail;
            base.BillType = "ST";
        }

        public PuInDetailForm(String action)
            :this()
        {
            InitForm(action);
          
        }

        public PuInDetailForm(int rowIndex, DataGridViewRowCollection ds)
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
            this.txtTitle.Text = "采购入库单";       
        }

        

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        private void ListRefresh()
        {

            if (PuInListForm != null)
            {
                PuInListForm.listRefresh();
            }
        }

        public override void New()
        {
            base.New();
            this.PuInInfo = new PuInInfo();
        } 
         

        private void gridMateriaDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gridMateriaDetail.CurrentRow != null)
            {
                if (this.gridMateriaDetail.CurrentCell.OwningColumn.Name.Equals("iDiscount") || this.gridMateriaDetail.CurrentCell.OwningColumn.Name.Equals("iNum"))
                {
                    MoneyCaculateService mcService = new MoneyCaculateService();
                    int iDiscount = int.Parse(this.gridMateriaDetail.CurrentRow.Cells["iDiscount"].Value.ToString());
                    int iNum =int.Parse(this.gridMateriaDetail.CurrentRow.Cells["iNum"].Value.ToString());
                    Decimal unitPrice = Decimal.Parse(this.gridMateriaDetail.CurrentRow.Cells["iUnitPrice"].Value.ToString());
                    this.gridMateriaDetail.CurrentRow.Cells["iAmt"].Value = mcService.MateriaMoneySumCaculate(unitPrice, iDiscount, iNum);
                }
            }
        }
         


    }
}
