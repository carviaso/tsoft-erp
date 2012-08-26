using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer; 

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class FaTypeForm : Form
    {
        private FaTypeService ftService;
        private FaTypeInfo faTypeInfo;
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
         
        
        public FaTypeForm()
        {
            InitializeComponent();
            ftService = new FaTypeService();
            faTypeInfo = new FaTypeInfo();
            
        }

        public FaTypeForm(int faType):this()
        {
            if (faType == 0)
            {
                TreeNode[] childs = new TreeNode[2];
                TreeNode node1 = new TreeNode("支出类别");
                node1.Name = "2";
                TreeNode node2 = new TreeNode("收入类别");
                node2.Name = "1";
                childs[0] = node1;
                childs[1] = node2;
                TreeNode root = new TreeNode("收支类别", childs);
                root.Name = "000000";
                treeFaType.Nodes.Add(root);
                InitGrid(null);
            }
            else if (faType == 1)
            {
                TreeNode root = new TreeNode("收入类别");
                root.Name = "1";
                treeFaType.Nodes.Add(root);
                InitGrid(1);
            }
            else if (faType == 2)
            {
                TreeNode root = new TreeNode("支出类别");
                root.Name = "2";
                treeFaType.Nodes.Add(root);
                InitGrid(2);
            }
        }

        public FaTypeForm(LabelRefer refer)
            : this()
        {
            _referFlag = 1;
            this._refer = refer;
        }

        public FaTypeForm(int faType,DataGridView dg, int row, int col)
            : this(faType)
        {
            _referFlag = 2;
            _dg = dg;
            _row = row;
            _col = col;
        }


        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitGrid(Object faType)
        {
            GridFetcher(faType);
            gridFaType.Columns["cGUID"].HeaderText = "代码";
            gridFaType.Columns["cGUID"].Visible = false;
            gridFaType.Columns["cCode"].HeaderText = "代码";
            gridFaType.Columns["cName"].HeaderText = "名称";
            gridFaType.Columns["cAccount"].HeaderText = "科目";


        }

        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(object con)
        {
            gridFaType.DataSource = ftService.QueryByType(con);
        }

        private void treeFaType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string cCode = treeFaType.SelectedNode.Name;
            GridFetcher(cCode);
            if (cCode == "000000")
            {
                setBtnStatus(false);
            }
            else
            {
                setBtnStatus(true);
            }
             
        }

        private void setBtnStatus(bool flag)
        {
            btnNew.Enabled = flag;
            btnView.Enabled = flag;
            btnForbidden.Enabled = flag;
            btnValueable.Enabled = flag;
            btnDelete.Enabled = flag;
            btnRefresh.Enabled = flag;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int iType = int.Parse(this.treeFaType.SelectedNode.Name);
            FaTypeDetailForm ftDetailForm = new FaTypeDetailForm(iType);
            ftDetailForm.FtForm = this;
            ftDetailForm.ShowDialog();
        }

        private void gridFaType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (_refer != null || _dg != null)
            {
                String value = this.gridFaType.Rows[e.RowIndex].Cells["cName"].Value.ToString();
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
                int iType = int.Parse(this.treeFaType.SelectedNode.Name);
                FaTypeDetailForm ftDetailForm = new FaTypeDetailForm(e.RowIndex, this.gridFaType.Rows, iType);
                ftDetailForm.FtForm = this;
                ftDetailForm.ShowDialog();

            }
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string cCode = treeFaType.SelectedNode.Name;
            GridFetcher(cCode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(faTypeInfo, gridFaType); 
                ftService.DoDel(faTypeInfo);
                MessageBox.Show(SysConst.msgDeleteSuccess);
                btnRefresh_Click(sender, e);
            }
            
             
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            　
            int rowIndex = this.gridFaType.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                int iType = int.Parse(this.treeFaType.SelectedNode.Name);
                FaTypeDetailForm ftDetailForm = new FaTypeDetailForm(rowIndex, this.gridFaType.Rows, iType);
                ftDetailForm.FtForm = this;
                ftDetailForm.ShowDialog();
            }
           
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(faTypeInfo, gridFaType);  
                ftService.DoForbidden(faTypeInfo);
                MessageBox.Show(SysConst.msgForbiddenSuccess);
            }             
        }

        private void btnValueable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SysConst.msgValueableConfirm, SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                BusinessControl.SetInfoByGrid(faTypeInfo, gridFaType);  
                ftService.DoValueable(faTypeInfo);
                MessageBox.Show(SysConst.msgValueableSuccess);
            } 
        }
    }
}
