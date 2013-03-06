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
    public partial class SaOutListForm : Form
    {
        private SaOutService SaOutService;
        private SaOutInfo SaOutInfo;
        private Condition _condition;

        public Condition FilterCondition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }


        public SaOutListForm()
        {
            InitializeComponent();
            SaOutService = new SaOutService();
            SaOutInfo = new SaOutInfo();
            InitGrid();
             
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowSaOutDetailForm(null);            
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
            DataTable result = SaOutService.GetDataByCondition(this.FilterCondition);
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
                ShowSaOutDetailForm(rowIndex);
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
                BusinessControl.SetInfoByGrid(SaOutInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否删除单据[" + SaOutInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    SaOutService.DoDel(SaOutInfo);
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
                BusinessControl.SetInfoByGrid(SaOutInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否审核单据[" + SaOutInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    SaOutService.DoAudit(SaOutInfo);
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
                BusinessControl.SetInfoByGrid(SaOutInfo, this.gridMemberSalary);
                DialogResult diaResult = Msg.Show("是否反审核单据[" + SaOutInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    SaOutService.DoUnAudit(SaOutInfo);
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


        private void ShowSaOutDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                SaOutDetailForm SaOutForm = new SaOutDetailForm((int)rowIndex, this.gridMemberSalary.Rows);
                SaOutForm.CtListForm = this;
                SaOutForm.ShowDialog();
            }
            else
            {
                SaOutDetailForm SaOutForm = new SaOutDetailForm("new");
                SaOutForm.CtListForm = this;
                SaOutForm.ShowDialog();
            }
        }  

        private void gridMemberSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnView_Click(null, null);
        }
 

    }
}
