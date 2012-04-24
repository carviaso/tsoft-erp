using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using TS.Sys.Platform.SecuAccess;
using TS.Sys.Platform.Exceptions; 

namespace TS.Forms.BusinessForm.BS
{
    public partial class SettleTypeForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private SettleTypeService stService;
        private SettleTypeInfo stInfo;  

        public SettleTypeForm()
        {
            InitializeComponent();
            stService = new SettleTypeService();
            stInfo = new SettleTypeInfo();
            TreeNode root = new TreeNode("结算方式");
            root.Name = "000000";
            treeSettleType.Nodes.Add(root);
            InitGrid();
        }

         /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public SettleTypeForm(LabelRefer refer)
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
        public SettleTypeForm(DataGridView dg, int row, int col)
            : this()
        {
            _referFlag = 2;
            _dg = dg;
            _row = row;
            _col = col;
        }

        private void gridSettleType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridSettleType.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid()
        {
            GridFetcher();
            gridSettleType.Columns["cGUID"].HeaderText = "编号";
            gridSettleType.Columns["cCode"].HeaderText = "代码";
            gridSettleType.Columns["cName"].HeaderText = "名称";
            gridSettleType.Columns["cAccount"].HeaderText = "科目";
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher()
        {
            gridSettleType.DataSource = stService.QueryAll();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = this.gridSettleType.SelectedRows[0].Index;
            SettleTypeDetailForm stDetailForm = new SettleTypeDetailForm(rowIndex, this.gridSettleType.Rows);
            stDetailForm.StForm = this;
            stDetailForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    BusinessControl.SetInfoByGrid(stInfo, this.gridSettleType);
                    stService.DoDel(stInfo);
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
            btnRefresh_Click(null,null);
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
                    BusinessControl.SetInfoByGrid(stInfo, this.gridSettleType);
                    stService.DoForbidden(stInfo);
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
                    BusinessControl.SetInfoByGrid(stInfo, this.gridSettleType);
                    stService.DoValueable(stInfo);
                    MessageBox.Show(SysConst.msgValueableSuccess);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SettleTypeDetailForm stDetailForm = new SettleTypeDetailForm();
            stDetailForm.StForm = this;
            stDetailForm.ShowDialog();
        }

        
    }
}
