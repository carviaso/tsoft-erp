using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao;

namespace TS.Sys.Platform.BaseData.Dao
{
    public class MateriaClassDao:BaseDao
    {
        private static string SQL_ALL = "select mc.cGUID,mc.cCode,mc.cName,mc.cFullName,acc.cName cAccount,CASE WHEN mc.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus,mc.cTimeStamp from CM_MateriaClassDao mc left join CM_AccountDetail acc on mc.cAcctCode = acc.cCode  ";
        private static string SQL_ALL_DETAIL = "select * from CM_MateriaClass mc   ";

        private static string TABLE = "CM_MateriaClass";

        public MateriaClassDao()
        {
            base.TableName = TABLE;
        }

        public void AddMateriaClass(MateriaClassInfo mcInfo)
        {
             Add(mcInfo);
        }

        public void ModifyMateriaClass(MateriaClassInfo mcInfo)
        {
             Modify(mcInfo);
        }

        public void DeleteMateriaClass(MateriaClassInfo mcInfo)
        {
             Delete(mcInfo);
        }

        public void ForbiddenMateriaClass(MateriaClassInfo mcInfo)
        {
             Forbidden(mcInfo);
        }

        public void ValueableMateriaClass(MateriaClassInfo mcInfo)
        {
             Valueable(mcInfo);
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
                iType = " where mc.iType = " + iType;
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
