using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info; 
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class RegionDao:BaseDao
    {
        private static string SQL_ALL = "select rg.cGUID,rg.cCode,rg.cName,rg.cTimeStamp,CASE WHEN rg.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_Region rg ";
        private static string TABLE = "CM_Region";

        public RegionDao()
        {
            base.TableName = TABLE;
        }

        public void  AddRegion(RegionInfo regionInfo)
        {
            Add(regionInfo);
        }

        public void  ModifyRegion(RegionInfo regionInfo)
        {
             Modify(regionInfo);
        }

        public void  DeleteRegion(RegionInfo regionInfo)
        {
             Delete(regionInfo);
        }

        public void  ForbiddenRegion(RegionInfo regionInfo)
        {
             Forbidden(regionInfo);
        }

        public void  ValueableRegion(RegionInfo regionInfo)
        {
             Valueable(regionInfo);
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
