using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Platform.BaseData.Info; 
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Dao;

namespace TS.Sys.Platform.BaseData.Dao
{
    public class FaTypeDao:BaseDao
    {
        private static string SQL_ALL = "select fa.cGUID,fa.cCode,fa.cName,fa.cFullName,acc.cName cAccount,CASE WHEN fa.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus,fa.cTimeStamp from CM_FaType fa left join CM_AccountDetail acc on fa.cAcctCode = acc.cCode  ";
        private static string SQL_ALL_DETAIL = "select * from CM_FaType fa   ";

        private static string TABLE = "CM_FaType";

        public FaTypeDao()
        {
            base.TableName = TABLE;
        }

        public void AddFaType(FaTypeInfo ftInfo)
        {
             Add(ftInfo);
        }

        public void ModifyFaType(FaTypeInfo ftInfo)
        {
             Modify(ftInfo);
        }

        public void DeleteFaType(FaTypeInfo ftInfo)
        {
             Delete(ftInfo);
        }

        public void ForbiddenFaType(FaTypeInfo ftInfo)
        {
             Forbidden(ftInfo);
        }

        public void ValueableFaType(FaTypeInfo ftInfo)
        {
             Valueable(ftInfo);
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
        public DataTable QueryForAll()
        {
            return GetDataTable(null);
        }

        /// <summary>
        /// 根据收支类别查询
        /// </summary>
        /// <param name="iType"></param>
        /// <returns></returns>
        public DataTable QueryByType(object iType)
        {
            if (iType != null)
            {
                iType = " where fa.iType = " + iType;
            }
            return GetDataTable(iType);
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
