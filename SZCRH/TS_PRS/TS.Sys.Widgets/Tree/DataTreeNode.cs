using System.Windows.Forms;
using System;

namespace TS.Sys.Platform.Widgets.Tree
{
    public class DataTreeNode:TreeNode
    {
        private object _oElement;

        public Object oElement
        {
            get { return this._oElement; }
            set { this._oElement = value; }
        }

        public DataTreeNode():base()
        {            
        }

        public DataTreeNode(string text)
            : base(text)
        {
        }

        public DataTreeNode(string text,TreeNode[] nodes):base(text,nodes)
        {
        }
    }
}
