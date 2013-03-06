using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Platform.BaseData.Info; 
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class UnitDao:BaseDao
    {
        private static string SQL_ALL = "select un.cGUID,un.cCode,un.cName,un.cTimeStamp,CASE WHEN un.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_Unit un ";
        private static string TABLE = "CM_Unit";

        public UnitDao()
        {
            base.TableName = TABLE;
        }

        public void  AddUnit(UnitInfo unitInfo)
        {
            Add(unitInfo);
        }

        public void  ModifyUnit(UnitInfo unitInfo)
        {
             Modify(unitInfo);
        }

        public void  DeleteUnit(UnitInfo unitInfo)
        {
             Delete(unitInfo);
        }

        public void  ForbiddenUnit(UnitInfo unitInfo)
        {
             Forbidden(unitInfo);
        }

        public void  ValueableUnit(UnitInfo unitInfo)
        {
             Valueable(unitInfo);
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
