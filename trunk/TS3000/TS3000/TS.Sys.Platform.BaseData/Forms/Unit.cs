using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SecuAccess;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;

namespace TS.Sys.Platform.BaseData.Forms
{
    public partial class UnitForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private UnitService unService;
        private UnitInfo unInfo;
        private String _cCode;

        public UnitForm()
        {
            InitializeComponent();
            unService = new UnitService();
            unInfo = new UnitInfo();
            TreeNode root = new TreeNode("单位");
            root.Name = "000000";
            treeUnit.Nodes.Add(root);
            _referFlag = 0;
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public UnitForm(LabelRefer refer)
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
        public UnitForm(DataGridView dg, int row, int col)
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
            GridFetcher();

            gridUnit.Columns["cGUID"].HeaderText = "编号";
            gridUnit.Columns["cGUID"].Visible = false;
            gridUnit.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridUnit.Columns["cTimeStamp"].Visible = false;
            gridUnit.Columns["cCode"].HeaderText = "代码";
            gridUnit.Columns["cName"].HeaderText = "名称";
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            gridUnit.DataSource = unService.QueryForAll();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridUnit.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            } 
           
        }

        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                UnitDetailForm unDetailForm = new UnitDetailForm((int)rowIndex, this.gridUnit.Rows);
                unDetailForm.UnForm = this;
                unDetailForm.ShowDialog();
            }
            else
            {
                UnitDetailForm unDetailForm = new UnitDetailForm("000000");
                unDetailForm.UnForm = this;
                unDetailForm.ShowDialog();
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
                    BusinessControl.SetInfoByGrid(unInfo, this.gridUnit);
                    unService.DoDel(unInfo);
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
            GridFetcher();
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnForbidden", this.GetType().Name);
                DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    BusinessControl.SetInfoByGrid(unInfo, this.gridUnit);
                    unService.DoForbidden(unInfo);
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
                    BusinessControl.SetInfoByGrid(unInfo, this.gridUnit);
                    unService.DoValueable(unInfo);
                    MessageBox.Show(SysConst.msgValueableSuccess);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowCostDetailForm(null); 
        }

        private void gridUnit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridUnit.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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
