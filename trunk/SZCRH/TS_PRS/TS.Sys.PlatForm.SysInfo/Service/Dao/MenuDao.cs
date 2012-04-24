using System;
using System.Collections;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Session; 

namespace TS.Sys.Platform.SysInfo.Dao
{
    public class MenuDao:BaseDao
    {
        private String _tableName = "Sys_Menu";


        /// <summary>
        /// con的条件格式必须为
        /// cField:Value
        /// cParent:Value
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(Hashtable con)
        {
            String sql = "select m.* from sys_Menu m inner join Sys_RoleSecu rs on rs.cSecu = m.cCode where rs.cRole = '"+UserSession.RoleID+"' and m.cParent like '%" + con["cParent"] + "%' and m.cField like '%" + con["cField"] + "%'";
            return DbSvr.GetDbService().GetListResult(sql);
        }

        internal ArrayList GetFlowList(Hashtable con)
        {
            String sql = "select m.*,mf.iX,mf.iY from Sys_ModualFlow mf inner join Sys_menu m on m.cCode = mf.cButton  where mf.cModual = '"+con["cModual"]+"'";
            return DbSvr.GetDbService().GetListResult(sql);
        }
    }
}
