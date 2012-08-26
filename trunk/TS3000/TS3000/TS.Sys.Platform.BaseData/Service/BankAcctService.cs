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
    public class BankAcctService : AbstractBaseService
    {
        private BankAccountDao bankAcctDao;
        public BankAcctService()
        {
            bankAcctDao = new BankAccountDao();
            base.Daos = bankAcctDao;
        }

        public void AddBank(BankInfo bankInfo)
        {
            bankAcctDao.AddBank(bankInfo);
        }

        public void DelBank(BankInfo bankInfo)
        {
            bankAcctDao.DelBank(bankInfo);
        }

        public void ModifyBank(BankInfo bankInfo)
        {
            bankAcctDao.ModifyBank(bankInfo);
        }

        public override void Add(BaseInfo baseInfo)
        {
            BankAccountInfo bankAcctInfo = (BankAccountInfo)baseInfo;
             bankAcctDao.AddBankAccount(bankAcctInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            BankAccountInfo bankAcctInfo = (BankAccountInfo)baseInfo;
             bankAcctDao.ModifyBankAccount(bankAcctInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            BankAccountInfo bankAcctInfo = (BankAccountInfo)baseInfo;
             bankAcctDao.DeleteBankAccount(bankAcctInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            BankAccountInfo bankAcctInfo = (BankAccountInfo)baseInfo;
             bankAcctDao.ForbiddenBankAccount(bankAcctInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            BankAccountInfo bankAcctInfo = (BankAccountInfo)baseInfo;
             bankAcctDao.ValueableBankAccount(bankAcctInfo);
        }


        public DataTable QueryResultByBank(Object cGUID)
        {
            return bankAcctDao.QueryAcctByParent(cGUID);
        }
 
    }
}
