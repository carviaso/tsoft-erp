using System;
using TS.Sys.Platform.Widgets;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Tree;
using System.Collections;

namespace TS.PRS.MemberMan.Business
{
    public class MemberReommendModual
    {
        private DataTree _dt;         
        private String _sql_MemberRecommend = "select m.cCode,m.cName,m.iForbidden iStatus from CM_Member m where m.cRecomMember ='{0}'";
        private int _baseAllowCo =40;

        private static MemberReommendModual _mrModual;

        private MemberReommendModual() {
            _dt = new DataTree();
            _dt.SqlFetcher = _sql_MemberRecommend;
            _dt.loadTreeDataBySql("会员推荐关系");
        }

        public static MemberReommendModual GetInstance()
        {
            if (_mrModual != null)
                return _mrModual;
            else
                return new MemberReommendModual();
        }

        public int BaseAllowCo
        {
            get { return this._baseAllowCo; }
            set { this._baseAllowCo = value; }
        }

        public DataTree  Dt
        {
            get { return this._dt; }
        }

        public String Sql_MemberRecommend
        {
            get { return this._sql_MemberRecommend; }
        }

        /// <summary>
        /// 获取该会员的团队数量
        /// 
        /// </summary>
        /// <param name="cMemberCode"></param>
        /// <returns></returns>
        public int GetMemberTeam(object cMemberCode)
        {
            DataTreeNode root = GetNode((DataTreeNode)_dt.TreeViewCtr.Nodes[0], cMemberCode.ToString());
            Hashtable e = (Hashtable)root.oElement;
            if (e["iStatus"].Equals(0))
            {
                int num = GetTeamNum(root, 0);

                return num;
            }
            else
            {               
                //如果离职人员，团队人数减一
                int num = GetTeamNum(root, 0);
                if (num > 0)
                    num--;
                return num;
            }
        }

        private int GetTeamNum(DataTreeNode n,int num)
        {
            foreach (DataTreeNode node in n.Nodes)
            {
                Hashtable e = (Hashtable)node.oElement;
                //只有在职人员才会算团队
                if (e["iStatus"].Equals(0))
                {
                    num++;
                }
                num = GetTeamNum(node, num);
            }
            return num;
        }

        private DataTreeNode GetNode(DataTreeNode n, String name)
        {
            if (n.Nodes[name] == null)
            {
                foreach (DataTreeNode node in n.Nodes)
                {
                    DataTreeNode nDetail = GetNode(node, name);
                    if (nDetail != null)
                    {
                        return nDetail;
                    }
                }
            }
            else
            {
                return (DataTreeNode)n.Nodes[name];
            }
            return null;

        }
    }
}
