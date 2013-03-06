using System;
using System.Data;
using System.Windows.Forms;
using TS.ERP.FA.Info;
using TS.ERP.FA.Service;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SecuAccess;

namespace TS.ERP.FA.Forms
{
    public partial class RevenListForm : Form
    {
        private RevenService RevenService;
        private RevenInfo RevenInfo;
        private Condition _condition;

        public Condition FilterCondition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }


        public RevenListForm()
        {
            InitializeComponent();
            RevenService = new RevenService();
            RevenInfo = new RevenInfo();
            InitGrid();
             
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowRevenDetailForm(null);            
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
            DataTable result = RevenService.GetDataByCondition(this.FilterCondition);
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
                ShowRevenDetailForm(rowIndex);
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
                BusinessControl.SetInfoByGrid(RevenInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否删除单据[" + RevenInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    RevenService.DoDel(RevenInfo);
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
                FunctionAccess.Access("btnAudit", this.GetType().Name);
                if (gridMemberSalary.Rows.Count == 0)
                {
                    Msg.Show(ExceptionConst.Error_NoAudit);
                    return;
                }
                BusinessControl.SetInfoByGrid(RevenInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否审核单据[" + RevenInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    RevenService.DoAudit(RevenInfo);
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
                FunctionAccess.Access("btnUnAudit", this.GetType().Name);
                if (gridMemberSalary.Rows.Count == 0)
                {
                    Msg.Show(ExceptionConst.Error_NoUnAudit);
                    return;
                }
                BusinessControl.SetInfoByGrid(RevenInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否反审核单据[" + RevenInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    RevenService.DoUnAudit(RevenInfo);
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


        private void ShowRevenDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                RevenDetailForm RevenForm = new RevenDetailForm((int)rowIndex, this.gridMemberSalary.Rows);
                RevenForm.CtListForm = this;
                RevenForm.ShowDialog();
            }
            else
            {
                RevenDetailForm RevenForm = new RevenDetailForm("new");
                RevenForm.CtListForm = this;
                RevenForm.ShowDialog();
            }
        }  

        private void gridMemberSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnView_Click(null, null);
        }
 

    }
}
