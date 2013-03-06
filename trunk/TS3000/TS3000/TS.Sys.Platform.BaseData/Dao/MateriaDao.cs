using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class MateriaDao:BaseDao
    {
        private static string SQL_ALL = "select * from CM_Materia mat  ";
        private static string SQL_LIST = "select mat.cGUID,mat.cCode,mat.cName,mat.cTimeStamp,CASE WHEN mat.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_Materia mat ";
        private static string TABLE = "CM_Materia";

        public MateriaDao()
        {
            base.TableName = TABLE;
        }

        public void AddMateria(MateriaInfo matinfo)
        {
             Add(matinfo);
        }

        public void ModifyMateria(MateriaInfo matinfo)
        {
             Modify(matinfo);
        }

        public void DeleteMateria(MateriaInfo matinfo)
        {
             Delete(matinfo);
        }

        public void ForbiddenMateria(MateriaInfo matinfo)
        {
             Forbidden(matinfo);
        }

        public void ValueableMateria(MateriaInfo matinfo)
        {
             Valueable(matinfo);
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
                cParent = " where mat.cParent='" + cParent + "'";
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
