using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class StorageDao:BaseDao
    {
        private static string SQL_ALL = "select * from CM_Storage store  ";
        private static string SQL_LIST = "select store.cGUID,store.cCode,store.cName,rg.cName cRegion,store.cTimeStamp,CASE WHEN store.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_Storage store left join CM_Region rg on store.cRegion = rg.cCode ";
        private static string TABLE = "CM_Storage";

        public StorageDao()
        {
            base.TableName = TABLE;
        }

        public void AddStorage(StorageInfo storeinfo)
        {
             Add(storeinfo);
        }

        public void ModifyStorage(StorageInfo storeinfo)
        {
             Modify(storeinfo);
        }

        public void DeleteStorage(StorageInfo storeinfo)
        {
             Delete(storeinfo);
        }

        public void ForbiddenStorage(StorageInfo storeinfo)
        {
             Forbidden(storeinfo);
        }

        public void ValueableStorage(StorageInfo storeinfo)
        {
             Valueable(storeinfo);
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

        public DataTable QueryByParent(object cParent)
        {
            if (cParent != null)
            {
                cParent = " where store.cParent='" + cParent + "'";
            }
            return GetDataTable(cParent);
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
