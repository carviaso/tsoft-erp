using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Platform.BaseData.Info; 
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class DepartmentDao:BaseDao
    {
        private static string SQL_ALL = "select dept.cGUID,dept.cCode,dept.cName,dept.cTimeStamp,CASE WHEN dept.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_Department dept  ";
        private static string SQL_TREE_SELECT = "select dept.cGUID,dept.cCode,dept.cName,dept.cTimeStamp from CM_Department dept where dept.cCode = @cCode UNION ALL select dept.cGUID,dept.cCode,dept.cName,dept.cTimeStamp from CM_Department dept where dept.cParent = @cCode1";
        private static string TABLE = "CM_Department";

        public DepartmentDao()
        {
            base.TableName = TABLE;
        }

        public void AddDepartment(DepartmentInfo deptInfo)
        {
             Add(deptInfo);
        }

        public void ModifyDepartment(DepartmentInfo deptInfo)
        {
             Modify(deptInfo);
        }

        public void DeleteDepartment(DepartmentInfo deptInfo)
        {
             Delete(deptInfo);
        }

        public void ForbiddenDepartment(DepartmentInfo deptInfo)
        {
             Forbidden(deptInfo);
        }

        public void ValueableDepartment(DepartmentInfo deptInfo)
        {
             Valueable(deptInfo);
        }

        public DataTable QueryTreeResult(Object cCode)
        {
            if (cCode == null)
            {
                return QueryForAll();
            }
            Hashtable con = new Hashtable();
            con.Add("cCode1", cCode);
            con.Add("cCode", cCode);
            String sql = SQL_TREE_SELECT;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql, con);
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
