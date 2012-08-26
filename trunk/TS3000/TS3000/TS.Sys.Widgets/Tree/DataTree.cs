using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Widgets.Tree;

namespace TS.Sys.Platform.Widgets
{
    public partial class DataTree : UserControl
    {
        public DataTree()
        {
            InitializeComponent();            
           
        }
        private DisplayTypeList _displayType = DisplayTypeList.CodeAndName;
        public enum DisplayTypeList
        {
            Name,
            Code,
            CodeAndName
        }

        public DisplayTypeList DisplayType
        {
            set { _displayType = value; }
            get { return this._displayType; }
        }

        private string table;

        /// <summary>
        /// 获取表名
        /// </summary>
        public string Table
        {
            set { this.table = value; }
            get { return this.table; }
        }

        private string sql;

        /// <summary>
        /// SQL取值器
        /// </summary>
        public string SqlFetcher
        {
            set { this.sql = value; }
            get { return this.sql; }
        }

        /// <summary>
        /// 激活控制
        /// </summary>
        private bool active;
        private ActiveSelection activeSelect;
        public enum ActiveSelection
        {
            False,
            True,
        }
        
        public TreeView TreeViewCtr
        {
            get
            {
                return this.treeView;
            }
            set
            {
                this.treeView = value;
            }
        }

        public ActiveSelection Active
        {
            set
            {
                activeSelect = value;
                if (value == ActiveSelection.True)
                {
                    active = true;
                    
                }
                else
                {
                   // treeView.Nodes.Clear();
                    active = false;
                }
                 

            }
            get { return this.activeSelect; }

        }

        private DataTreeNode selectedNode;
        public DataTreeNode GetSelectedNode()
        {
            return this.selectedNode;
        }

        public void setAcitve(bool flag)
        {
            this.active = flag;
        }

        /// <summary>
        /// 通过单表构造树节点 
        /// </summary>
        /// <param name="rootTitle"></param>
        public void loadTreeDataByTable(string rootTitle)
        {
            DataTreeNode[] n = TreeFetcher("select cGUID,cCode,cName,cParent from " + this.table + " where cParent='{0}'","000000");
            treeView.ImageList = image_tree;
            DataTreeNode root = null;
            try
            {
                if (n == null)
                {
                    root = new DataTreeNode(rootTitle);
                }
                else
                {
                    root = new DataTreeNode(rootTitle, n);
                }
                root.Name = "000000";
                
                treeView.Nodes.Add(root);

            }
            catch (ArgumentNullException e)
            {

            }
        }

        /// <summary>
        /// 通过SQL构造树节点
        /// </summary>
        /// <param name="rootTitle"></param>
        public void loadTreeDataBySql(string rootTitle)
        {
            DataTreeNode[] n = TreeFetcher(this.sql,"000000");
            treeView.ImageList = image_tree;
            try
            {
                DataTreeNode root = new DataTreeNode(rootTitle, n);
                root.Name = "000000";
                treeView.Nodes.Add(root);

            }
            catch (ArgumentNullException e)
            {

            }
        }

        /// <summary>
        /// 树的取值器
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private DataTreeNode[] TreeFetcher(string sql,string id)
        {

            ArrayList result = DbSvr.GetDbService().GetListResult(sql, new Object[] { id });
            if (result.Count == 0)
            {
                return null;
            }
            DataTreeNode[] nodes = new DataTreeNode[result.Count];
            int i = 0;
            foreach (Hashtable info in result)
            {

                String cCode = (string)info["cCode"];
                String cText = "";
                if (_displayType == DisplayTypeList.CodeAndName)
                {
                    cText = (string)info["cCode"] + " " + (string)info["cName"];//树节点文本构造 编码+名称
                }
                else if(_displayType == DisplayTypeList.Name)
                {
                    cText = (string)info["cName"];//树节点文本构造 编码
                }
                DataTreeNode[] childs = TreeFetcher(sql, cCode);
                if (childs != null)
                {
                    DataTreeNode node = new DataTreeNode(cText, childs);
                    node.oElement = info;
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    node.Name = cCode;
                    nodes[i] = node;
                    i++;
                }
                else
                {
                    DataTreeNode node = new DataTreeNode(cText);
                    node.oElement = info;
                    node.ImageIndex = 2;
                    node.SelectedImageIndex = 2;
                    node.Name = cCode;
                    nodes[i] = node;
                    i++;
                }


            }
            return nodes;

        }

        /// <summary>
        /// 自定义事件，TextBoxKeyDown事件
        /// </summary>
        public event EventHandler AfterTreeNodeSelect;

        /// <summary>
        /// 双击时根据是否为叶子节点以及是否展开，改变树节点的图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (treeView.SelectedNode.IsExpanded && treeView.SelectedNode.ImageIndex != 2)
                {
                    treeView.SelectedNode.SelectedImageIndex = 1;
                }
                else if (!treeView.SelectedNode.IsExpanded && treeView.SelectedNode.ImageIndex != 2)
                {
                    treeView.SelectedNode.SelectedImageIndex = 0;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        /// <summary>
        /// 选择的时候根据展开状态和是否叶子节点设置树节点的图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.IsExpanded && e.Node.ImageIndex != 2)
            {
                e.Node.SelectedImageIndex = 1;
            }
            else if (!e.Node.IsExpanded && e.Node.ImageIndex != 2)
            {
                e.Node.SelectedImageIndex = 0;
            }
            this.selectedNode = (DataTreeNode)e.Node;
            if (AfterTreeNodeSelect != null)
                AfterTreeNodeSelect(this, e);
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        /// <summary>
        /// 自定义事件，AfterTreeNodeCheck事件
        /// 在点击CheckBox之后
        /// </summary>
        public event TreeViewEventHandler AfterTreeNodeCheck;
        private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (AfterTreeNodeCheck != null)
                AfterTreeNodeCheck(this, e);
            
        }

        public event TreeViewCancelEventHandler BeforeTreeNodeCheck;
        private void treeView_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (BeforeTreeNodeCheck != null)
                BeforeTreeNodeCheck(this, e);
            
        }

    }
}
