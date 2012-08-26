using System;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Util; 
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using TS.Sys.Platform.SecuAccess;
using TS.Sys.Platform.Exceptions;

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class SupplyForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private SupplyService spService;
        private SupplyInfo spInfo;   
        public SupplyForm()
        {
            InitializeComponent();
            spService = new SupplyService();
            spInfo = new SupplyInfo();
            this.treeRegion.loadTreeDataByTable("地区");
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public SupplyForm(LabelRefer refer)
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
        public SupplyForm(DataGridView dg, int row, int col)
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
            gridSupply.Columns["cGUID"].HeaderText = "编号";
            gridSupply.Columns["cGUID"].Visible = false;
            gridSupply.Columns["cTimeStamp"].HeaderText = "时间戳";
            gridSupply.Columns["cTimeStamp"].Visible = false;
            gridSupply.Columns["cCode"].HeaderText = "代码";
            gridSupply.Columns["cName"].HeaderText = "名称";
            gridSupply.Columns["cRegion"].HeaderText = "所属地区";
        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(object cRegion)
        {
            gridSupply.DataSource = spService.QueryByRegion(cRegion);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SupplyDetailForm supDetailForm =new SupplyDetailForm();
            supDetailForm.cRegionValue = treeRegion.GetSelectedNode().Name;
            supDetailForm.SpForm = this;
            supDetailForm.ShowDialog();            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SupplyDetailForm supDetailForm = new SupplyDetailForm(this.gridSupply.SelectedRows[0].Index, this.gridSupply.Rows);
            supDetailForm.SpForm = this;
            supDetailForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", this.GetType().Name);
                DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    BusinessControl.SetInfoByGrid(spInfo, this.gridSupply);
                    spService.DoDel(spInfo);
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
            treeRegion_AfterTreeNodeSelect(null, null);
        }

       
        private void btnForbidden_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnForbidden", this.GetType().Name);
                DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    BusinessControl.SetInfoByGrid(spInfo, this.gridSupply);
                    spService.DoForbidden(spInfo);
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
                    BusinessControl.SetInfoByGrid(spInfo, this.gridSupply);
                    spService.DoValueable(spInfo);
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

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(string con)
        {
            gridSupply.DataSource = spService.QueryByRegion(con);
        }

        private void gridSupply_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridSupply.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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

        private void treeRegion_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            string cCode = treeRegion.GetSelectedNode().Name;
            if ("000000".Equals(cCode))
            {
                GridFetcher(null);
            }
            else
            {
                GridFetcher(cCode);
            }
        }

        
    }
}
