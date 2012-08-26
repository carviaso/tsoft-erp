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
    public partial class CustomerForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private CustomerService custService;
        private CustomerInfo custInfo;
        private String _cCode;
        private static string STR_CUST="客户";

        public CustomerForm()
        {
            InitializeComponent();
            custService = new CustomerService();
            custInfo = new CustomerInfo();
            this.treeRegion.loadTreeDataByTable("地区");
            _referFlag = 0;
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public CustomerForm(LabelRefer refer)
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
        public CustomerForm(DataGridView dg, int row, int col)
            : this()
        {
            _referFlag = 2;
            _dg = dg;
            _row = row;
            _col = col;
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher(null);
            gridCustomer.Columns["cGUID"].HeaderText = "编号";
            gridCustomer.Columns["cGUID"].Visible = false; 
            gridCustomer.Columns["cTimeStamp"].Visible = false;
            gridCustomer.Columns["cCode"].HeaderText = "代码";
            gridCustomer.Columns["cName"].HeaderText = "名称";
            gridCustomer.Columns["cRegion"].HeaderText = "所属地区";
            gridCustomer.Columns["iStatus"].HeaderText = "状态";
        }
        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(string con)
        {
            gridCustomer.DataSource = custService.QueryByRegion(con);
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }

        private void treeRegion_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            _cCode = treeRegion.GetSelectedNode().Name;
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
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridCustomer.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }

        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                CustomerDetailForm custDetailForm = new CustomerDetailForm((int)rowIndex, this.gridCustomer.Rows);
                custDetailForm.CustForm = this;
                custDetailForm.ShowDialog();
            }
            else
            {
                CustomerDetailForm custDetailForm = new CustomerDetailForm(_cCode);
                custDetailForm.CustForm = this;
                custDetailForm.ShowDialog(); 
            }
        }      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                BusinessControl.SetInfoByGrid(custInfo, this.gridCustomer);
                DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm + STR_CUST + "[" + custInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    custService.DoDel(custInfo);
                    MessageBox.Show(SysConst.msgDeleteSuccess);
                    btnRefresh_Click(sender, e);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }
         

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            treeRegion_AfterTreeNodeSelect(null, null);
        }

       
        private void btnForbidden_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnForbidden", this.GetType().Name);
                BusinessControl.SetInfoByGrid(custInfo, this.gridCustomer);
                DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm + STR_CUST + "[" + custInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    custService.DoForbidden(custInfo);
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
                BusinessControl.SetInfoByGrid(custInfo, this.gridCustomer);
                DialogResult diaResult = MessageBox.Show(SysConst.msgValueableConfirm + STR_CUST + "[" + custInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (diaResult == DialogResult.OK)
                {
                    custService.DoValueable(custInfo);
                    MessageBox.Show(SysConst.msgForbiddenSuccess);
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

        

        private void gridCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridCustomer.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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
                btnView_Click(null, null);
            }
        } 

        
    }
}
