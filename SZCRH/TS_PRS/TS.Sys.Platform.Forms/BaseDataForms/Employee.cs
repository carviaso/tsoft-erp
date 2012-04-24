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
    public partial class EmployeeForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private EmployeeService empService;
        private EmployeeInfo empInfo;
        private String _cCode;

        public EmployeeForm()
        {
            InitializeComponent();
            empService = new EmployeeService();
            empInfo = new EmployeeInfo();
            treeDepartment.loadTreeDataByTable("部门");
            _referFlag = 0;
            InitGrid();
        } 



        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public EmployeeForm(LabelRefer refer)
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
        public EmployeeForm(DataGridView dg, int row, int col)
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
            gridEmployee.Columns["cGUID"].HeaderText = "编号";
            gridEmployee.Columns["cGUID"].Visible = false;
            gridEmployee.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridEmployee.Columns["cTimeStamp"].Visible = false;
            gridEmployee.Columns["cCode"].HeaderText = "编号";
            gridEmployee.Columns["cName"].HeaderText = "名称";
            gridEmployee.Columns["iSex"].HeaderText = "性别";
            gridEmployee.Columns["cDepartment"].HeaderText = "部门";
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(string con)
        {
            gridEmployee.DataSource = empService.QueryByDepartment(con);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridEmployee.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            } 
        }

        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                EmployeeDetailForm empDetailForm = new EmployeeDetailForm((int)rowIndex, this.gridEmployee.Rows);
                empDetailForm.EmpForm = this;
                empDetailForm.ShowDialog();
            }
            else
            {
                EmployeeDetailForm empDetailForm = new EmployeeDetailForm(_cCode);
                empDetailForm.EmpForm = this;
                empDetailForm.ShowDialog();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowCostDetailForm(null); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeDepartment_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            _cCode = this.treeDepartment.GetSelectedNode().Name;
            if ("000000".Equals(_cCode))
            {
                GridFetcher(null);
            }
            else
            {
                GridFetcher(_cCode);
            }
        }

        private void gridEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridEmployee.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    BusinessControl.SetInfoByGrid(empInfo, gridEmployee);
                    empService.DoDel(empInfo);
                    MessageBox.Show(SysConst.msgDeleteSuccess);
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
            treeDepartment_AfterTreeNodeSelect(null, null);
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnForbidden", this.GetType().Name);
                DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    BusinessControl.SetInfoByGrid(empInfo, gridEmployee);
                    empService.DoForbidden(empInfo);
                    MessageBox.Show(SysConst.msgForbiddenSuccess);
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
                DialogResult result = MessageBox.Show(SysConst.msgValueableConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    BusinessControl.SetInfoByGrid(empInfo, gridEmployee);
                    empService.DoValueable(empInfo);
                    MessageBox.Show(SysConst.msgValueableSuccess);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        
    }
}
