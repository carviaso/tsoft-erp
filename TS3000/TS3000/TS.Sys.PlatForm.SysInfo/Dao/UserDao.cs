using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Platform.SysInfo.Info;
using System.Text; 

namespace TS.Sys.Platform.SysInfo.Dao
{
    public class UserDao:BaseDao
    {
        private static string SQL_ALL = "select u.cGUID,u.cCode,u.cName,CASE WHEN u.iForbidden = 0 THEN '启用' ELSE '禁用' END  iStatus,u.cTimeStamp from Sys_User u  ";
        private static string SQL_ALL_DETAIL = "select * from Sys_User user";
        private static string TABLE = "Sys_User";
        private static string TABLE_PWD = "Sys_UserSecu";

        public UserDao()
        {
            base.TableName = TABLE;
        }

        public void AddUser(UserInfo userInfo)
        {
             Add(userInfo);
        }

        public void ModifyUser(UserInfo userInfo)
        {
             Modify(userInfo);
        }

        public void DeleteUser(UserInfo userInfo)
        {
             Delete(userInfo);
        }

        public void ForbiddenUser(UserInfo userInfo)
        {
             Forbidden(userInfo);
        }

        public void ValueableUser(UserInfo userInfo)
        {
             Valueable(userInfo);
        }

        /// <summary>
        /// 添加密码
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="pwd"></param>
        internal void AddPwd(UserInfo userInfo, String pwd)
        {
            Hashtable con = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            con.Add("cGUID",cGUID);
            con.Add("cUser",userInfo.cCode);
            con.Add("cPassword", pwd);
            DbSvr.GetDbService().Insert(TABLE_PWD, con);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="pwd"></param>
        internal void ModifyPwd(UserInfo userInfo, String pwd)
        {
            Hashtable con = new Hashtable();
            con.Add("cUser", userInfo.cCode);
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            userInfo.cTimeStamp = cTimeStamp;
            Hashtable value = new Hashtable();
            value.Add("cPassword",pwd);
            
            DbSvr.GetDbService().Update(TABLE_PWD, value, con);
        }

        internal ArrayList GetUserPwd(UserInfo userInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cUser", userInfo.cCode);
            return DbSvr.GetDbService().GetExitsResult(TABLE_PWD, con);
        }

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(object con)
        {
            String sql = SQL_ALL_DETAIL + con;
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            return result;
        }

       
            /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserByRole(object con)
        {
            if (con != null)
            {
                con = " where u.cRole = '"+con+"'";
            }
            String sql = SQL_ALL + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        } 
        

    }
}
