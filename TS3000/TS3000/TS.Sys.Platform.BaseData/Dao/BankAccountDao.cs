using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Dao;

namespace TS.Sys.Platform.BaseData.Dao
{
    public class BankAccountDao:BaseDao
    {
        private static string SQL_ALL = "select * from CM_BankAccount bacct  ";
        private static string SQL_GUID_ALL = "select cGUID,cName from CM_BankAccount ";
        private static string TABLE = "CM_Bank";
        private static string TABLE_BANK = "CM_BankAccount";

        public BankAccountDao()
        {
            base.TableName = TABLE;
        }
          

        public void AddBankAccount(BankAccountInfo bankInfo)
        {
             Add(bankInfo);
        }

        public void ModifyBankAccount(BankAccountInfo bankInfo)
        {
             Modify(bankInfo);
        }

        public void DeleteBankAccount(BankAccountInfo bankInfo)
        {
             Delete(bankInfo);
        }

        public void ForbiddenBankAccount(BankAccountInfo bankInfo)
        {
             Forbidden(bankInfo);
        }

        public void ValueableBankAccount(BankAccountInfo bankInfo)
        {
             Valueable(bankInfo);
        } 

        public ArrayList GetForAllGUID()
        {
            ArrayList result = DbSvr.GetDbService().GetListResult(SQL_GUID_ALL);
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

        public DataTable QueryAcctByParent(Object cCode)
        {
            if (cCode != null)
            {
                cCode = " where  bankAcct.cBank = '" + cCode + "'";
            }
            else
            {
                cCode = "";
            }
            String sql = "select bankAcct.cGUID,bankAcct.cCode,bankAcct.cName,bankAcct.cAccount,bankAcct.cTimeStamp,CASE WHEN bankAcct.iForbidden = 0 THEN '启用' ELSE '禁用' END iStatus,bank.cName cBank from  CM_BankAccount bankAcct inner join CM_Bank bank on bankAcct.cBank =bank.cCode " + cCode;
            return  DbSvr.GetDbService().GetDataTable(sql);
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
