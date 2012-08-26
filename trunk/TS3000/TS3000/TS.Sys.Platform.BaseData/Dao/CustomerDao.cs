using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao; 

namespace TS.Sys.Platform.BaseData.Dao
{
    public class CustomerDao:BaseDao
    {
        private static string SQL_ALL = "select * from CM_Customer cust  ";
        private static string SQL_LIST = "select cust.cGUID,cust.cCode,cust.cName,rg.cName cRegion,cust.cTimeStamp,CASE WHEN cust.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus from CM_Customer cust left join CM_Region rg on cust.cRegion = rg.cCode ";
        private static string TABLE = "CM_Customer";

        public CustomerDao()
        {
            base.TableName = TABLE;
        }

        public void AddCustomer(CustomerInfo custinfo)
        {
             Add(custinfo);
        }

        public void ModifyCustomer(CustomerInfo custinfo)
        {
             Modify(custinfo);
        }

        public void DeleteCustomer(CustomerInfo custinfo)
        {
             Delete(custinfo);
        }

        public void ForbiddenCustomer(CustomerInfo custinfo)
        {
             Forbidden(custinfo);
        }

        public void ValueableCustomer(CustomerInfo custinfo)
        {
             Valueable(custinfo);
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

        public DataTable QueryByRegion(object cRegion)
        {
            if (cRegion != null)
            {
                cRegion = " where cust.cRegion='" + cRegion + "'";
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
