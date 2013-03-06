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
    public class BankService : AbstractBaseService
    {
        private BankDao bankDao;
        public BankService()
        {
            bankDao = new BankDao();
            base.Daos = bankDao;
        }

        public void AddBank(BankInfo bankInfo)
        {
            bankDao.AddBank(bankInfo);
        }

        public void DelBank(BankInfo bankInfo)
        {
            bankDao.DeleteBank(bankInfo);
        }

        public void ModifyBank(BankInfo bankInfo)
        {
            bankDao.ModifyBank(bankInfo);
        }

        public override void Add(BaseInfo baseInfo)
        {
            BankInfo bankInfo = (BankInfo)baseInfo;
             bankDao.AddBank(bankInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            BankInfo bankInfo = (BankInfo)baseInfo;
             bankDao.ModifyBank(bankInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            BankInfo bankInfo = (BankInfo)baseInfo;
             bankDao.DeleteBank(bankInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            BankInfo bankInfo = (BankInfo)baseInfo;
             bankDao.ForbiddenBank(bankInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            BankInfo bankInfo = (BankInfo)baseInfo;
             bankDao.ValueableBank(bankInfo);
        }


        public DataTable QueryResultByBank(Object cGUID)
        {
            return bankDao.QueryAcctByParent(cGUID);
        }
 
    }
}
