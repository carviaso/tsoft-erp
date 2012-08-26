using System;
using System.Collections;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Session;

namespace TS.Sys.Platform.SysInfo.Dao
{
    public class ModualDao:BaseDao
    {
        private String _tableName = "Sys_Modual";


        /// <summary>
        /// con的条件格式必须为 
        /// 1、business：业务
        /// 2、base：基础数据
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(Object con)
        {
            if (con != null)
            {
                con = "  and m.cType = '" + con + "'";
            }
            String sql = "select m.* from " + _tableName + " m inner join Sys_RoleSecu rs on rs.cSecu = m.cName where rs.cRole = '" + UserSession.RoleID + "'";
         
            return DbSvr.GetDbService().GetListResult(sql+con);
        }
    }
}
