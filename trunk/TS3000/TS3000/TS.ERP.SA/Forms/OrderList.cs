using System;
using System.Data;
using System.Windows.Forms;
using TS.ERP.SA.Info;
using TS.ERP.SA.Service;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SecuAccess;

namespace TS.ERP.SA.Forms
{
    public partial class OrderListForm : Form
    {
        private OrderService OrderService;
        private OrderInfo OrderInfo;
        private Condition _condition;

        public Condition FilterCondition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }


        public OrderListForm()
        {
            InitializeComponent();
            OrderService = new OrderService();
            OrderInfo = new OrderInfo();
            InitGrid();
             
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowOrderDetailForm(null);            
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
            DataTable result = OrderService.GetDataByCondition(this.FilterCondition);
            gridMemberSalary.DataSource = result;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (gridMemberSalary.Rows.Count == 0)
            {
                Msg.Show(ExceptionConst.Error_View);
                return;
            }
            int rowIndex = this.gridMemberSalary.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowOrderDetailForm(rowIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                if (gridMemberSalary.Rows.Count == 0)
                {
                    Msg.Show(ExceptionConst.Error_Del);
                    return;
                }
                BusinessControl.SetInfoByGrid(OrderInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否删除单据[" + OrderInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    OrderService.DoDel(OrderInfo);
                    Msg.Show(SysConst.msgDeleteSuccess);
                    btnRefresh_Click(sender, e);


                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }

        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridFetcher();
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            try
            {
               // FunctionAccess.Access("btnAudit", this.GetType().Name);
                if (gridMemberSalary.Rows.Count == 0)
                {
                    Msg.Show(ExceptionConst.Error_NoAudit);
                    return;
                }
                BusinessControl.SetInfoByGrid(OrderInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否审核单据[" + OrderInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    OrderService.DoAudit(OrderInfo);
                    Msg.Show(SysConst.msgAuditSuccess);
                    btnRefresh_Click(sender, e);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnUnAudit_Click(object sender, EventArgs e)
        {
            try
            {
                //FunctionAccess.Access("btnUnAudit", this.GetType().Name);
                if (gridMemberSalary.Rows.Count == 0)
                {
                    Msg.Show(ExceptionConst.Error_NoUnAudit);
                    return;
                }
                BusinessControl.SetInfoByGrid(OrderInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否反审核单据[" + OrderInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    OrderService.DoUnAudit(OrderInfo);
                    Msg.Show(SysConst.msgUnAuditSuccess);
                    btnRefresh_Click(sender, e);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ShowOrderDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                OrderDetailForm OrderForm = new OrderDetailForm((int)rowIndex, this.gridMemberSalary.Rows);
                OrderForm.CtListForm = this;
                OrderForm.ShowDialog();
            }
            else
            {
                OrderDetailForm OrderForm = new OrderDetailForm("new");
                OrderForm.CtListForm = this;
                OrderForm.ShowDialog();
            }
        }  

        private void gridMemberSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnView_Click(null, null);
        }
 

    }
}
