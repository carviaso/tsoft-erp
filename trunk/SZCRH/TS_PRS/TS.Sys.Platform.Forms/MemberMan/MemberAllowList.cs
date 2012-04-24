using System;
using System.Data;
using System.Windows.Forms;
using TS.PRS.MemberMan.Info;
using TS.PRS.MemberMan.Service;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SecuAccess;

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberAllowListForm : Form
    {
        private MembersAllowService maService;
        private MembersAllowInfo maInfo;
        public MemberAllowListForm()
        {
            InitializeComponent();
            maService = new MembersAllowService();
            maInfo = new MembersAllowInfo();
            InitGrid();
             
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowCostDetailForm(null);            
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher();
            
            gridMemberAllow.Columns["cCode"].HeaderText = "单编号";
            gridMemberAllow.Columns["cCode"].Frozen = true; 
            gridMemberAllow.Columns["dDate"].HeaderText = "单据日期";
            gridMemberAllow.Columns["iMemberNum"].HeaderText = "会员人数";
            gridMemberAllow.Columns["iAllowSum"].HeaderText = "津贴总额";            
            gridMemberAllow.Columns["cRemark"].HeaderText = "备注";
            gridMemberAllow.Columns["cAuditStatus"].HeaderText = "审核状态";
            gridMemberAllow.Columns["cAuditor"].HeaderText = "审核人";
            gridMemberAllow.Columns["dAuditDate"].HeaderText = "审核日期";
            gridMemberAllow.Columns["cDepartment"].HeaderText = "部门";
            gridMemberAllow.Columns["cCreator"].HeaderText = "制单人";
            gridMemberAllow.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridMemberAllow.Columns["cTimeStamp"].Visible = false;
            gridMemberAllow.Columns["cGUID"].HeaderText = "编号";
            gridMemberAllow.Columns["cGUID"].Visible = false;
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            DataTable result = maService.QueryForAll();
            gridMemberAllow.DataSource = result;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (gridMemberAllow.Rows.Count == 0)
            {
                Msg.Show(ExceptionConst.Error_View);
                return;
            }
            int rowIndex = this.gridMemberAllow.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                if (gridMemberAllow.Rows.Count == 0)
                {
                    Msg.Show(ExceptionConst.Error_Del);
                    return;
                }
                BusinessControl.SetInfoByGrid(maInfo, this.gridMemberAllow);
                DialogResult diaResult = Msg.Show("是否删除单据[" + maInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    maService.DoDel(maInfo);
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
                if (gridMemberAllow.Rows.Count == 0)
                {
                    Msg.Show(ExceptionConst.Error_NoAudit);
                    return;
                }
                BusinessControl.SetInfoByGrid(maInfo, this.gridMemberAllow);
                DialogResult diaResult = Msg.Show("是否审核单据[" + maInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    maService.DoAudit(maInfo);
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
                if (gridMemberAllow.Rows.Count == 0)
                {
                    Msg.Show(ExceptionConst.Error_NoUnAudit);
                    return;
                }
                BusinessControl.SetInfoByGrid(maInfo, this.gridMemberAllow);
                DialogResult diaResult = Msg.Show("是否反审核单据[" + maInfo.cCode + "]？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult == DialogResult.OK)
                {

                    maService.DoUnAudit(maInfo);
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


        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                MemberAllowDetailForm maForm = new MemberAllowDetailForm((int)rowIndex, this.gridMemberAllow.Rows);
                maForm.MAListForm = this;
                maForm.ShowDialog();
            }
            else
            {
                MemberAllowDetailForm maForm = new MemberAllowDetailForm("new");
                maForm.MAListForm = this;
                maForm.ShowDialog();
            }
        } 

        private void btnMemberRecommend_Click(object sender, EventArgs e)
        {
            new MemberRecommendForm().ShowDialog();
        }

        private void gridMemberAllow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnView_Click(null, null);
        }   
    }
}
