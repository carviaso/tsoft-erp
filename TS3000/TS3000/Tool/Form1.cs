using System;
using System.Windows.Forms;
using System.Collections;
using TS.Sys.DBLayer;

namespace Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefershTree();
        }

        private void RefershTree()
        {
            
            this.treeSecu.loadTreeDataByTable("系统菜单");
            this.treeSecu.TreeViewCtr.ExpandAll();
        }

        private void ClearTree(TreeNode node)
        {
            if (node != null)
            {
                if (node.Nodes != null && node.Nodes.Count > 0)
                {
                    foreach (TreeNode n in node.Nodes)
                    {
                        ClearTree(n);
                    }
                }
                else
                {
                    this.treeSecu.TreeViewCtr.Nodes.Remove(node);
                }
            }
        }

        private void btnModual_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(this.cParent.Value);
            f.ShowDialog();
             
        }

        private void save_Click(object sender, EventArgs e)
        {
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            Hashtable con = new Hashtable();
            con.Add("cGUID", cGUID);
            con.Add("cCode", cCode.Value);
            con.Add("cName", cName.Value);
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            con.Add("cTimeStamp",cTimeStamp); 
            con.Add("cParent",cParent.Value);
            con.Add("iForbidden",0);
            DbSvr.GetDbService().Insert("Sys_SysModualBtn",con);
            GetGridData();
            cCode.Value = null;
            cName.Value = null;
        }

        private void treeSecu_AfterTreeNodeSelect(object sender, EventArgs e)
        {
            this.cParent.Value = this.treeSecu.GetSelectedNode().Name;
            GetGridData();
        }

        private void GetGridData()
        {
            this.dataGridView1.DataSource = DbSvr.GetDbService().GetDataTable("select cGUID,cCode,cName,cParent from Sys_SysModualBtn where cParent = '" + cParent.Value + "'");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Hashtable con = new Hashtable();
            Object cGUID = this.dataGridView1.SelectedRows[0].Cells["cGUID"].Value;
            con.Add("cGUID",cGUID);
            DbSvr.GetDbService().Delete("Sys_SysModualBtn", con);
            GetGridData();
        }
    }
}
