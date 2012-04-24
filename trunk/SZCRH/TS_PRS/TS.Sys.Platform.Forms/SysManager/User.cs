using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Service;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;

namespace TS.Sys.Platform.Forms.SysManager
{
    public partial class UserForm : Form
    {
        private LabelRefer _refer;
        private DataGridView _dg;
        private int _row;
        private int _col;
        private int _referFlag;
        private UserService userService;
        private UserInfo userInfo; 
        private String _cCode ;

        public UserForm()
        {
            InitializeComponent();
            this.treeRole.loadTreeDataByTable("角色");
            userService = new UserService();
            userInfo = new UserInfo();
            userInfo = new UserInfo();
            _referFlag = 0;
            InitGrid();
        }

        /// <summary>
        /// 由控件弹出
        /// </summary>
        /// <param name="refer"></param>
        public UserForm(LabelRefer refer)
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
        public UserForm(DataGridView dg, int row, int col)
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
            gridUser.Columns["cGUID"].Visible = false;
            gridUser.Columns["cTimeStamp"].Visible = false;
            gridUser.Columns["cCode"].HeaderText = "代码";
            gridUser.Columns["cName"].HeaderText = "名称";
            gridUser.Columns["iStatus"].HeaderText = "状态"; 


        }
        /// <summary>
        /// 列表数据取值器
        /// </summary>
        /// <param name="con">条件</param>
        private void GridFetcher(string con)
        {
           gridUser.DataSource = userService.GetUserByRole(con); 
        }

        internal void listRefresh()
        {
            btnRefresh_Click(null, null);
        }
        #endregion

        #region 控件事件
        private void treeRole_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            _cCode = treeRole.GetSelectedNode().Name;
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
            UserDetailForm userDetailForm = new UserDetailForm(_cCode);
            userDetailForm.UserManForm = this;
            userDetailForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gridUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_refer != null)
            {
                String value = this.gridUser.Rows[e.RowIndex].Cells["cCode"].Value.ToString();
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
            int rowIndex = this.gridUser.SelectedRows[0].Index;
            if (rowIndex >= 0)
            {
                ShowCostDetailForm(rowIndex);
            }
        }
        private void ShowCostDetailForm(Object rowIndex)
        {
            if (rowIndex != null)
            {
                UserDetailForm userDetailForm = new UserDetailForm((int)rowIndex, this.gridUser.Rows);
                userDetailForm.UserManForm = this;
                userDetailForm.ShowDialog();
            }
            else
            {
                UserDetailForm userDetailForm = new UserDetailForm(_cCode);
                userDetailForm.UserManForm = this;
                userDetailForm.ShowDialog();
            }
        }      

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            treeRole_AfterTreeNodeSelect(null, null);
        }
             

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(userInfo, this.gridUser);
            DialogResult result = MessageBox.Show(SysConst.msgDeleteConfirm + "账号[" + userInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {                
                userService.DoDel(userInfo);
                MessageBox.Show(SysConst.msgDeleteSuccess);
                btnRefresh_Click(sender, e);
            }
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(userInfo, this.gridUser);
            DialogResult result = MessageBox.Show(SysConst.msgForbiddenConfirm + "账号[" + userInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {                
                userService.DoForbidden(userInfo);
                MessageBox.Show(SysConst.msgForbiddenSuccess);
                btnRefresh_Click(sender, e);
            }
        }

        private void btnValueable_Click(object sender, EventArgs e)
        {
            BusinessControl.SetInfoByGrid(userInfo, this.gridUser);
            DialogResult diaResult = MessageBox.Show(SysConst.msgValueableConfirm + "账号[" + userInfo.cCode + "]？", SysConst.msgBoxTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (diaResult == DialogResult.OK)
            {
                userService.DoValueable(userInfo);
                MessageBox.Show(SysConst.msgForbiddenSuccess);
                btnRefresh_Click(sender, e);
            }
        }
        #endregion
    }
}
