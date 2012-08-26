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
    public partial class RegionForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private RegionService rgService;
        private RegionInfo rgInfo;
        private String _cCode;

        public RegionForm()
        {
            InitializeComponent();
            rgService = new RegionService();
            rgInfo = new RegionInfo();
            TreeNode root = new TreeNode("区域");
            root.Name = "000000";
            treeRegion.Nodes.Add(root);
            _referFlag = 0;
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public RegionForm(LabelRefer refer)
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
        public RegionForm(DataGridView dg, int row, int col)
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

            gridRegion.Columns["cGUID"].HeaderText = "编号";
            gridRegion.Columns["cGUID"].Visible = false;
            gridRegion.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridRegion.Columns["cTimeStamp"].Visible = false;
            gridRegion.Columns["cCode"].HeaderText = "代码";
            gridRegion.Columns["cName"].HeaderText = "名称";
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            gridRegion.DataSource = rgService.QueryForAll();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridRegion.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            } 
           
        }

        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                RegionDetailForm rgDetailForm = new RegionDetailForm((int)rowIndex, this.gridRegion.Rows);
                rgDetailForm.RgForm = this;
                rgDetailForm.ShowDialog();
            }
            else
            {
                RegionDetailForm rgDetailForm = new RegionDetailForm("000000");
                rgDetailForm.RgForm = this;
                rgDetailForm.ShowDialog();
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
                    BusinessControl.SetInfoByGrid(rgInfo, this.gridRegion);
                    rgService.DoDel(rgInfo);
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
                    BusinessControl.SetInfoByGrid(rgInfo, this.gridRegion);
                    rgService.DoForbidden(rgInfo);
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
                    BusinessControl.SetInfoByGrid(rgInfo, this.gridRegion);
                    rgService.DoValueable(rgInfo);
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

        private void gridRegion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridRegion.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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
