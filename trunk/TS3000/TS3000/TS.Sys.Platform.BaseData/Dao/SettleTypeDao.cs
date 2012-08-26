using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class SettleTypeDao:BaseDao
    {
        private static string SQL_ALL = "select se.cGUID,se.cCode,se.cName,acc.cName cAccount,CASE WHEN se.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_SettleType se left join CM_AccountDetail acc on se.cAcctGUID = acc.cGUID";
        private static string TABLE = "CM_SettleType";

        public SettleTypeDao()
        {
            base.TableName = TABLE;
        }

        public void AddSettleType(SettleTypeInfo settleInfo)
        {
             Add(settleInfo);
        }

        public void ModifySettleType(SettleTypeInfo settleInfo)
        {
             Modify(settleInfo);
        }

        public void DeleteSettleType(SettleTypeInfo settleInfo)
        {
             Delete(settleInfo);
        }

        public void ForbiddenSettleType(SettleTypeInfo settleInfo)
        {
             Forbidden(settleInfo);
        }

        public void ValueableSettleType(SettleTypeInfo settleInfo)
        {
             Valueable(settleInfo);
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
