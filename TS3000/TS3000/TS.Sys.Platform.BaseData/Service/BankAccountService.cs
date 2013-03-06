using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.BaseData.Info;
using System.Data;

namespace TS.Sys.Platform.BaseData.Service
{
    public class BankAccountService : AbstractBaseService
    {
        private BankAccountDao bankDao;
        public BankAccountService()
        {
            bankDao = new BankAccountDao();
            base.Daos = bankDao;
        }

        public void AddBankAccount(BankAccountInfo bankInfo)
        {
            bankDao.AddBankAccount(bankInfo);
        }

        public void DelBankAccount(BankAccountInfo bankInfo)
        {
            bankDao.DeleteBankAccount(bankInfo);
        }

        public void ModifyBankAccount(BankAccountInfo bankInfo)
        {
            bankDao.ModifyBankAccount(bankInfo);
        }

        public override void Add(BaseInfo baseInfo)
        {
            BankAccountInfo bankInfo = (BankAccountInfo)baseInfo;
             bankDao.AddBankAccount(bankInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            BankAccountInfo bankInfo = (BankAccountInfo)baseInfo;
             bankDao.ModifyBankAccount(bankInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            BankAccountInfo bankInfo = (BankAccountInfo)baseInfo;
             bankDao.DeleteBankAccount(bankInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            BankAccountInfo bankInfo = (BankAccountInfo)baseInfo;
             bankDao.ForbiddenBankAccount(bankInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            BankAccountInfo bankInfo = (BankAccountInfo)baseInfo;
             bankDao.ValueableBankAccount(bankInfo);
        }


        public DataTable QueryResultByParent(Object cGUID)
        {
            return bankDao.QueryAcctByParent(cGUID);
        }
 
    }
}
