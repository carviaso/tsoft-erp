using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class SupplyDao:BaseDao
    {
        private static string SQL_ALL = "select * from CM_Supply sup  ";
        private static string SQL_LIST = "select sup.cGUID,sup.cCode,sup.cName,rg.cName cRegion,sup.cTimeStamp,CASE WHEN sup.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_Supply sup left join CM_Region rg on sup.cRegion = rg.cCode ";
        private static string TABLE = "CM_Supply";

        public SupplyDao()
        {
            base.TableName = TABLE;
        }

        public void AddSupply(SupplyInfo supInfo)
        {
             Add(supInfo);             
        }

        public void ModifySupply(SupplyInfo supInfo)
        {
             Modify(supInfo);             
        }

        public void DeleteSupply(SupplyInfo supInfo)
        {
             Delete(supInfo);
        }

        public void ForbiddenSupply(SupplyInfo supInfo)
        {
             Forbidden(supInfo);
        }

        public void ValueableSupply(SupplyInfo supInfo)
        {
             Valueable(supInfo);
        }

     

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(object con)
        {
            String sql = SQL_ALL  + con;
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

        public DataTable QueryByRegion(object cRegion)
        {
            if (cRegion != null)
            {
                cRegion = " where sup.cRegion='" + cRegion + "'";
            } 
            return GetDataTable(cRegion);
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
    }
}
