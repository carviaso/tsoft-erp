using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Platform.SysInfo.Info;
using System.Data.SqlClient;

namespace TS.Sys.Platform.SysInfo.Dao
{
    public class RoleDao : BaseDao
    {
        private static string SQL_ALL = "select ro.cGUID,ro.cCode,ro.cName from Sys_Role ro  ";
        private static string SQL_LIST = "select ro.cGUID,ro.cCode,ro.cName ,CASE WHEN (select count(*) from Sys_RoleSecu rs where rs.cRole = ro.cCode) =0 THEN '未分配' ELSE '已分配' END as SecuStatus,CASE WHEN ro.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus,ro.cTimeStamp  from  Sys_Role ro ";
        private static string SQL_GUID_ALL = "select cGUID,cName from Sys_Role ";
        private static string TABLE = "Sys_Role";
        private static string TABLE_ROLE = "Sys_RoleSecu";
        private static string TABLE_BUTTON = "Sys_RoleBtnSecu";

        public RoleDao()
        {
            base.TableName = TABLE;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roleInfo"></param>
        public void AddRole(RoleInfo roleInfo)
        {
            Add(roleInfo);
        }
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="roleInfo"></param>
        public void ModifyRole(RoleInfo roleInfo)
        {
            Modify(roleInfo);
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="roleInfo"></param>
        public SqlCommand DeleteRole(RoleInfo roleInfo)
        {
            return GetDelCommand(roleInfo);
        }

        public void ForbiddenRole(RoleInfo roleInfo)
        {
            Forbidden(roleInfo);
        }

        public void ValueableRole(RoleInfo roleInfo)
        {
            Valueable(roleInfo);
        }
        /// <summary>
        /// 添加模块权限
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public SqlCommand AddSecu(Hashtable con)
        {
            return DbSvr.GetDbService().GetInsertCommand(TABLE_ROLE, con);
        }
        /// <summary>
        /// 删除模块权限
        /// </summary>
        /// <param name="roleInfo"></param>
        /// <returns></returns>
        public SqlCommand DelSecu(RoleInfo roleInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cRole",roleInfo.cCode);
            return DbSvr.GetDbService().GetDeleteCommand(TABLE_ROLE, con);
        }

        /// <summary>
        /// 删除按钮权限的命令
        /// </summary>
        /// <param name="roleInfo"></param>
        /// <returns></returns>
        public SqlCommand DelBtnSecu(RoleInfo roleInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cRole", roleInfo.cCode);
            return DbSvr.GetDbService().GetDeleteCommand(TABLE_BUTTON, con);
        }

        /// <summary>
        /// 获取添加按钮权限的命令
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public SqlCommand AddBtnSecu(Hashtable con)
        {
            return DbSvr.GetDbService().GetInsertCommand(TABLE_BUTTON, con);
        }

        public ArrayList GetForAllGUID()
        {
            ArrayList result = DbSvr.GetDbService().GetListResult(SQL_GUID_ALL);
            return result;
        }

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(object con)
        {
            String sql = SQL_ALL + con;
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            return result;
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(object con)
        {
            String sql = SQL_LIST + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }

        public ArrayList GetSecuList(RoleInfo roInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cRole", roInfo.cCode);
            ArrayList result = DbSvr.GetDbService().GetListResult("select cSecu,cRole from " + TABLE_ROLE + " where cRole=@cRole", con);
            return result;
        }

        public ArrayList GetBtnSecu(RoleInfo roInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cRole", roInfo.cCode);
            ArrayList result = DbSvr.GetDbService().GetListResult("select cBtnSecu,cRole,cModual from " + TABLE_BUTTON + " where cRole=@cRole", con);
            return result;
        }

    }
}
