using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Util;
using TS.Sys.PlatForm.BaseData.Service;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using TS.Sys.Platform.SecuAccess;
using TS.Sys.Platform.Exceptions; 

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class AccountForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private AccountService acctService;
        private AccountInfo acctInfo;
        private String _cCode;

        public AccountForm()
        {
            
            InitializeComponent();
            this.treeAccount.loadTreeDataByTable("科目");
            acctService = new AccountService();
            acctInfo = new AccountInfo();
            _referFlag = 0;
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public AccountForm(LabelRefer refer)
            : this()
        {
            _referFlag = 1;
            this._refer = refer;
        }


        /// <summary>
        /// 由列表弹出
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public AccountForm(DataGridView dg, int row, int col)
            : this()
        {
            _referFlag = 2;
            _dg = dg;
            _row = row;
            _col = col;
        }
        #region 私有方法
        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher(null);
            gridAccount.Columns["cGUID"].Visible = false;
            gridAccount.Columns["cTimeStamp"].Visible = false;
            gridAccount.Columns["cCode"].HeaderText = "科目代码";
            gridAccount.Columns["cName"].HeaderText = "科目名称";


        }
        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(string con)
        {
            gridAccount.DataSource = acctService.QueryAcctByParent(con); 
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }
        #endregion

        #region 控件事件
        private void treeAccount_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            _cCode = this.treeAccount.GetSelectedNode().Name;
            if ("000000".Equals(_cCode))
            {
                GridFetcher(null);
            }
            else
            {
                GridFetcher(_cCode);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowCostDetailForm(null);

            
            AccountDetailForm acctDetailForm = new AccountDetailForm();
            acctDetailForm.AccForm = this;
            acctDetailForm.ShowDialog();
        }

        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                AccountDetailForm acctDetailForm = new AccountDetailForm((int)rowIndex, this.gridAccount.Rows);
                acctDetailForm.AccForm = this;
                acctDetailForm.ShowDialog();
            }
            else
            {
                AccountDetailForm acctDetailForm = new AccountDetailForm(_cCode);
                acctDetailForm.AccForm = this;
                acctDetailForm.ShowDialog();
            }
        }  

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gridAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridAccount.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
                if (_referFlag == 1)
                {
                    _refer.Value = value;
                }
                else
                {
                    _dg[_col, _row].Value = value;
                }
                this.Close();
            }
            else
            {
                btnView_Click(null,null);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridAccount.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            treeAccount_AfterTreeNodeSelect(null, null);
        }
        #endregion       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                BusinessControl.SetInfoByGrid(acctInfo, this.gridAccount);
                DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm + "科目[" + acctInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    acctService.DoDel(acctInfo);
                    MessageBox.Show(SysConst.msgDeleteSuccess);
                    btnRefresh_Click(sender, e);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnForbidden", this.GetType().Name);
                BusinessControl.SetInfoByGrid(acctInfo, this.gridAccount);
                DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm + "科目[" + acctInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    acctService.DoForbidden(acctInfo);
                    MessageBox.Show(SysConst.msgForbiddenSuccess);
                    btnRefresh_Click(sender, e);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnValueable_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnValueable", this.GetType().Name);
                BusinessControl.SetInfoByGrid(acctInfo, this.gridAccount);
                DialogResult diaResult = MessageBox.Show(SysConst.msgValueableConfirm + "科目[" + acctInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (diaResult == DialogResult.OK)
                {

                    acctService.DoValueable(acctInfo);
                    MessageBox.Show(SysConst.msgForbiddenSuccess);
                    btnRefresh_Click(sender, e);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

       
    }
}
