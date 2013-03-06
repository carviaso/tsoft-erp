using System;
using System.Data;
using System.Windows.Forms;
using TS.ERP.ST.Info;
using TS.ERP.ST.Service;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SecuAccess;

namespace TS.ERP.ST.Forms
{
    public partial class StockListForm : Form
    {
        private StockService StockService;
        private StockInfo StockInfo;
        private Condition _condition;

        public Condition FilterCondition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }


        public StockListForm()
        {
            InitializeComponent();
            StockService = new StockService();
            StockInfo = new StockInfo();
            InitGrid();
             
        }

        

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher();
            
            gridMemberSalary.Columns["cCode"].HeaderText = "单编号";
            gridMemberSalary.Columns["cCode"].Frozen = true; 
            gridMemberSalary.Columns["dDate"].HeaderText = "单据日期";            
            gridMemberSalary.Columns["cRemark"].HeaderText = "备注";
            gridMemberSalary.Columns["cAuditStatus"].HeaderText = "审核状态";
            gridMemberSalary.Columns["cAuditor"].HeaderText = "审核人";
            gridMemberSalary.Columns["dAuditDate"].HeaderText = "审核日期";
            gridMemberSalary.Columns["cDepartment"].HeaderText = "部门";
            gridMemberSalary.Columns["cCreator"].HeaderText = "制单人";
            gridMemberSalary.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridMemberSalary.Columns["cTimeStamp"].Visible = false;
            gridMemberSalary.Columns["cGUID"].HeaderText = "编号";
            gridMemberSalary.Columns["cGUID"].Visible = false;
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            DataTable result = StockService.GetDataByCondition(this.FilterCondition);
            gridMemberSalary.DataSource = result;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
        }
         

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridFetcher();
        }
          

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         

        private void gridMemberSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnView_Click(null, null);
        }
 

    }
}
