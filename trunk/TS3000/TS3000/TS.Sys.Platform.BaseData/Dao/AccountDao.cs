using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain; 
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class AccountDao:BaseDao
    {
        private static string SQL_ALL = "select * from CM_AccountDetail acct  ";
        private static string SQL_GUID_ALL = "select cGUID,cName from CM_AccountDetail "; 
        private static string TABLE = "CM_AccountDetail";

        public AccountDao()
        {
            base.TableName = TABLE;
        }

        public void AddAccount(AccountInfo accInfo)
        {
             Add(accInfo);
        }

        public void ModifyAccount(AccountInfo accInfo)
        {
             Modify(accInfo);
        }

        public void DeleteAccount(AccountInfo accInfo)
        {
             Delete(accInfo);
        }

        public void ForbiddenAccount(AccountInfo accInfo)
        {
             Forbidden(accInfo);
        }

        public void ValueableAccount(AccountInfo accInfo)
        {
             Valueable(accInfo);
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
        public DataTable QueryForAll()
        {
            return GetDataTable(null);
        }

        public DataTable QueryAcctByParent(Object cCode)
        {
            if (cCode != null)
            {
                cCode = " where acc.cParent = '" + cCode + "'";
            }
            else
            {
                cCode = "";
            }
            String sql = "select acc.cGUID,acc.cCode,acc.cName,CASE WHEN acc.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus,acc.cTimeStamp from  CM_AccountDetail acc" + cCode;
            return  DbSvr.GetDbService().GetDataTable(sql);
        }
        

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(object con)
        {
            String sql = SQL_ALL + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }  
    }
}
