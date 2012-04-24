using System.Windows.Forms;
using TS.Sys.Platform.SysInfo.Info;
using System.Collections;
using System;
using TS.Sys.Domain;
using TS.Sys.Platform.SysInfo.Service;
using TS.Sys.Platform.Exceptions;

namespace TS.Sys.Platform.Forms.SysManager
{
    public partial class RoleSecuForm : Form
    {
        private RoleInfo _roleInfo;
        private RoleService _roleService;
        private ButtonService _btnService;
        private RoleForm _roleForm;
        private ArrayList _secuList;
        public RoleSecuForm()
        {
            InitializeComponent();            
        }

        public RoleSecuForm(RoleInfo roleInfo,RoleForm roleForm)
            :this()
        {
            _roleInfo = roleInfo;
            _roleService = new RoleService();
            _btnService = new ButtonService();
            _roleForm = roleForm;
            _secuList = roleInfo.BtnSecu;
            this.cCode.Value = roleInfo.cCode;
            this.cName.Value = roleInfo.cName;
            this.treeSecu.loadTreeDataByTable("系统菜单");
            this.treeSecu.TreeViewCtr.CheckBoxes = true;
            this.treeSecu.TreeViewCtr.ExpandAll();
            SetSecu(roleInfo.Secu); 
        }


        /// <summary>
        /// 设置子表值
        /// </summary>
        /// <param name="resultSub"></param>
        /// <param name="grid"></param>
        private void SetSubContent(ArrayList result, DataGridView grid)
        {
            grid.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                Hashtable detail = (Hashtable)result[i];
                Object[] cellValues = new Object[detail.Count+1];
                cellValues[0] = "1";
                int index = 1;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (detail[col.Name] != null)
                    {
                        Object value = detail[col.Name];
                        cellValues[index] = value;
                        index++;
                    }
                }
                grid.Rows.Add(cellValues);

            }
        }

        /// <summary>
        /// 列出模块下所有的按钮
        /// </summary>
        /// <param name="cParent"></param>
        private  void InitGrid(object cParent)
        {
            ArrayList result = _btnService.GetBtnList(cParent);
            SetSubContent(result, this.gridBtnSecu);
        }

        /// <summary>
        /// 设置该角色的按钮权限
        /// 0：true；1：false；
        /// </summary>
        /// <param name="secuList"></param>
        /// <param name="modual"></param>
        private void InitSecu(ArrayList secuList, String modual)
        {
            foreach (Object o in secuList)
            {
                Hashtable secu = (Hashtable)o;
                if (!secu["cModual"].ToString().Equals(modual))
                    continue;
                foreach (DataGridViewRow row in gridBtnSecu.Rows)
                {
                    if (row.Cells["cBtnCode"].Value.Equals(secu["cBtnSecu"]))
                    {
                        row.Cells["secStatus"].Value = "0";
                    }
                }
            }
        }

        private void SetSecu(ArrayList secuList)
        {

            this.treeSecu.TreeViewCtr.Nodes[0].Checked = true;
            foreach (Object o in secuList)
            {
                Hashtable secu = (Hashtable)o;

                TreeNode a = GetAllNodes(this.treeSecu.TreeViewCtr.Nodes[0],secu["cSecu"].ToString());
                if (a != null)
                {
                    a.Checked = true;
                }
                continue;

            }
        }

        private TreeNode GetAllNodes(TreeNode n,String name)
        {
            if (n.Nodes[name] == null)
            {
                foreach (TreeNode node in n.Nodes)
                {
                    TreeNode nDetail = GetAllNodes(node, name);
                    if (nDetail != null)
                    {
                        return nDetail;
                    }
                }
            }
            else
            {
                return n.Nodes[name];
            }
            return null;
            
        }

        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void treeSecu_AfterTreeNodeCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {

                if (e.Node.Checked)
                {
                    
                    //节点选中之后，取消所有父节点的选中状态
                    setChildNodeCheckedState(e.Node, true);

                }
                else
                {
                    //取消节点选中状态之后，取消所有父节点的选中状态
                    setChildNodeCheckedState(e.Node, false);
                }
            }
        }
        //取消节点选中状态之后，取消所有父节点的选中状态
        private void setParentNodeCheckedState(TreeNode currNode, bool state)
        {
            TreeNode parentNode = currNode.Parent;

            parentNode.Checked = state;
            if (currNode.Parent.Parent != null)
            {
                setParentNodeCheckedState(currNode.Parent, state);
            }
        }
        //选中节点之后，选中节点的所有子节点
        private void setChildNodeCheckedState(TreeNode currNode, bool state)
        {
            TreeNodeCollection nodes = currNode.Nodes;
            if (nodes.Count > 0)
                foreach (TreeNode tn in nodes)
                {

                    tn.Checked = state;
                    setChildNodeCheckedState(tn, state);
                }
        }

        private void treeSecu_BeforeTreeNodeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                if (e.Node.Parent == null)
                {
                    Msg.Show("根节点不能取消！");
                    e.Cancel = true;
                    return;
                }
                if (!e.Node.Parent.Checked)
                {
                    Msg.Show("请先选择" + e.Node.Parent.Text+ "！");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList result = new ArrayList();
                SetAllNodes(treeSecu.TreeViewCtr.Nodes[0], result);
                _roleInfo.Secu = result;
                _roleService.AddSecu(_roleInfo); 
                _roleInfo.BtnSecu = _secuList;
                _roleService.AddBtnSecu(_roleInfo);
                _roleForm.listRefresh();
                Msg.Show("权限已分配！");
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        } 
        private void SetAllNodes(TreeNode n,ArrayList result)
        {

            foreach (TreeNode node in n.Nodes)
            {
                if (node.Checked)
                {
                    Hashtable rs = new Hashtable();
                    rs.Add("cRole", _roleInfo.cCode);
                    rs.Add("cSecu", node.Name);
                    result.Add(rs);
                }
                SetAllNodes(node,result);

            }
        }

        private void treeSecu_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            String cParent = this.treeSecu.GetSelectedNode().Name;
            InitGrid(cParent);
            InitSecu(_secuList, cParent);
        }
         

        private void gridBtnSecu_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.gridBtnSecu.EndEdit();
                DataGridViewRow row = this.gridBtnSecu.Rows[e.RowIndex];
                if (row.Cells["secStatus"].Value.Equals("0"))
                {

                    foreach (Object o in _secuList)
                    {
                        Hashtable con = (Hashtable)o;
                        if (con["cModual"].Equals(row.Cells["cModualCode"].Value) && con["cBtnSecu"].Equals(row.Cells["cBtnCode"].Value))
                        {
                            break;
                        }

                    }
                    Hashtable rs = new Hashtable();
                    rs.Add("cRole", _roleInfo.cCode);
                    rs.Add("cBtnSecu", row.Cells["cBtnCode"].Value);
                    rs.Add("cModual", row.Cells["cModualCode"].Value);
                    _secuList.Add(rs);

                }
                else
                {
                    foreach (Object o in _secuList)
                    {
                        Hashtable con = (Hashtable)o;
                        if (con["cModual"].Equals(row.Cells["cModualCode"].Value) && con["cBtnSecu"].Equals(row.Cells["cBtnCode"].Value))
                        {
                            _secuList.Remove(o);
                            break;
                        }

                    }

                }
            }
        }
    }
}
