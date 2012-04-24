using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Service;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;

namespace TS.Sys.Platform.Forms.SysManager
{
    public partial class RoleForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private RoleService roleService;
        private RoleInfo roleInfo; 
        private String _cCode;

        public RoleForm()
        {
            InitializeComponent();
            roleService = new RoleService(); 
            roleInfo = new RoleInfo();
            _referFlag = 0;
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public RoleForm(LabelRefer refer)
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
        public RoleForm(DataGridView dg, int row, int col)
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
            gridRole.Columns["cGUID"].Visible = false;
            gridRole.Columns["cTimeStamp"].Visible = false;
            gridRole.Columns["cCode"].HeaderText = "代码";
            gridRole.Columns["cName"].HeaderText = "名称";
            gridRole.Columns["SecuStatus"].HeaderText = "权限分配";
            gridRole.Columns["iStatus"].HeaderText = "状态";

        }
        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(object con)
        {
            gridRole.DataSource = roleService.GetDataTable(con); 
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }
        #endregion

        #region 控件事件


        /// <summary>
        /// 新增事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
          
            RoleDetailForm roleDetailForm = new RoleDetailForm(_cCode);
            roleDetailForm.RoleListForm= this;
            roleDetailForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gridRole_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridRole.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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
            int rowIndex = this.gridRole.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }
        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                RoleDetailForm roleDetailForm = new RoleDetailForm((int)rowIndex, this.gridRole.Rows);
                roleDetailForm.RoleListForm = this;
                roleDetailForm.ShowDialog();
            }
            else
            {
                RoleDetailForm roleDetailForm = new RoleDetailForm(_cCode);
                roleDetailForm.RoleListForm = this;
                roleDetailForm.ShowDialog();
            }
        }      

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridFetcher(null);
        }
             

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(roleInfo, this.gridRole);
            DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm + "账号[" + roleInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {                
                roleService.DoDel(roleInfo);
                MessageBox.Show(SysConst.msgDeleteSuccess);
                btnRefresh_Click(sender, e);
            }
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(roleInfo, this.gridRole);
            DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm + "账号[" + roleInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {                
                roleService.DoForbidden(roleInfo);
                MessageBox.Show(SysConst.msgForbiddenSuccess);
                btnRefresh_Click(sender, e);
            }
        }

        private void btnValueable_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(roleInfo, this.gridRole);
            DialogResult diaResult = MessageBox.Show(SysConst.msgValueableConfirm + "账号[" + roleInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (diaResult == DialogResult.OK)
            {
                roleService.DoValueable(roleInfo);
                MessageBox.Show(SysConst.msgForbiddenSuccess);
                btnRefresh_Click(sender, e);
            }
        }
        #endregion

        private void btnSecu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.gridRole.SelectedRows[0];
            if (row != null)
            {
                String code = row.Cells["cCode"].Value.ToString();
                String name = row.Cells["cName"].Value.ToString();
                RoleSecuForm rsForm = new RoleSecuForm(roleInfo,this);
                rsForm.ShowDialog();
            }
        }

        private void gridRole_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gridRole.Rows[e.RowIndex];
            BusinessControl.SetInfoProperties(roleInfo, row);
            roleService.GetSeucList(roleInfo);
            roleService.GetBtnSecu(roleInfo);
        }
    }
}
