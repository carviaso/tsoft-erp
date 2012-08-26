using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class EmployeeDao:BaseDao
    {
        private static string SQL_ALL_LIST = "select emp.cGUID,emp.cCode,emp.cName,case iSex when 1 then '男' else '女' end as iSex,dept.cName cDepartment,emp.cTimeStamp,CASE WHEN emp.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_Employee emp left join CM_Department dept on emp.cDepartment = dept.cCode";

        private static string SQL_ALL_DETAIL = "select * from CM_Employee emp";

        private static string TABLE = "CM_Employee";

        public EmployeeDao()
        {
            base.TableName = TABLE;
        }

        public void AddEmployee(EmployeeInfo empInfo)
        {
             Add(empInfo);
        }

        public void ModifyEmployee(EmployeeInfo empInfo)
        {
             Modify(empInfo);
        }

        public void DeleteEmployee(EmployeeInfo empInfo)
        {
             Delete(empInfo);
        }

        public void ForbiddenEmployee(EmployeeInfo empInfo)
        {
             Forbidden(empInfo);
        }

        public void ValueableEmployee(EmployeeInfo empInfo)
        {
             Valueable(empInfo);
        }

        /// <summary>
        /// 获取所有记录集
        /// </summary>
        /// <returns></returns>
        public ArrayList GetAllResult()
        {
            return GetResultList(null);
        }

        /// <summary>
        /// 根据部门查询
        /// </summary>
        /// <param name="cDepartment"></param>
        /// <returns></returns>
        public ArrayList GetResultByDepartment(object cDepartment)
        {
            cDepartment = GetDepartmentCondition(cDepartment);
            return GetResultList(cDepartment);
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
        /// 根据部门获取数据源
        /// </summary>
        /// <param name="cDepartment"></param>
        /// <returns></returns>
        public DataTable QueryByDepartment(object cDepartment)
        {
            cDepartment = GetDepartmentCondition(cDepartment);
            return GetDataTable(cDepartment);

        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(object con)
        {
            String sql = SQL_ALL_LIST + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }
         

        private static object GetDepartmentCondition(object cDepartment)
        {
            if (cDepartment != null)
            {
                cDepartment = " where emp.cDepartment = '" + cDepartment+"'";
            }
            return cDepartment;
        }
         
    }
}
