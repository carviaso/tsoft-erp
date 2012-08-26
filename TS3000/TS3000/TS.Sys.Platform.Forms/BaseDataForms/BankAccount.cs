using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using TS.Sys.Platform.SecuAccess;
using TS.Sys.Platform.Exceptions; 

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class BankAccountForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private BankAcctService bankAcctService;
        private BankInfo bankInfo;
        private BankAccountInfo bankAcctInfo;
        private String _cCode ;

        public BankAccountForm()
        {
            InitializeComponent();
            this.treeBank.loadTreeDataByTable("银行");
            bankAcctService = new BankAcctService();
            bankAcctInfo = new BankAccountInfo();
            bankInfo = new BankInfo();
            _referFlag = 0;
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public BankAccountForm(LabelRefer refer)
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
        public BankAccountForm(DataGridView dg, int row, int col)
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
            gridBankAccount.Columns["cGUID"].Visible = false;
            gridBankAccount.Columns["cTimeStamp"].Visible = false;
            gridBankAccount.Columns["cCode"].HeaderText = "代码";
            gridBankAccount.Columns["cName"].HeaderText = "名称";
            gridBankAccount.Columns["cBank"].HeaderText = "银行";
            gridBankAccount.Columns["cBankAcct"].HeaderText = "账户";


        }
        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(string con)
        {
            gridBankAccount.DataSource = bankAcctService.QueryResultByBank(con); 
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }
        #endregion

        #region 控件事件
        private void bankTree_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            _cCode = treeBank.GetSelectedNode().Name;
            if ("000000".Equals(_cCode))
            {
                GridFetcher(null);
            }
            else
            {
                GridFetcher(_cCode);
            }
        }

        /// <summary>
        /// 新增事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowCostDetailForm(null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gridBankAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridBankAccount.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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
            int rowIndex = this.gridBankAccount.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }
        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                BankAccountDetailForm acctDetailForm = new BankAccountDetailForm((int)rowIndex, this.gridBankAccount.Rows);
                acctDetailForm.BankAcctForm = this;
                acctDetailForm.ShowDialog();
            }
            else
            {
                BankAccountDetailForm acctDetailForm = new BankAccountDetailForm(_cCode);
                acctDetailForm.BankAcctForm = this;
                acctDetailForm.ShowDialog();
            }
        }      

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bankTree_AfterTreeNodeSelect(null, null);
        }
             

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                BusinessControl.SetInfoByGrid(bankInfo, this.gridBankAccount);
                DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm + "账号[" + bankInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    bankAcctService.DoDel(bankInfo);
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
                BusinessControl.SetInfoByGrid(bankInfo, this.gridBankAccount);
                DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm + "账号[" + bankInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    bankAcctService.DoForbidden(bankInfo);
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
                BusinessControl.SetInfoByGrid(bankInfo, this.gridBankAccount);
                DialogResult diaResult = MessageBox.Show(SysConst.msgValueableConfirm + "账号[" + bankInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (diaResult == DialogResult.OK)
                {
                    bankAcctService.DoValueable(bankInfo);
                    MessageBox.Show(SysConst.msgForbiddenSuccess);
                    btnRefresh_Click(sender, e);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }
        #endregion
    }
}
