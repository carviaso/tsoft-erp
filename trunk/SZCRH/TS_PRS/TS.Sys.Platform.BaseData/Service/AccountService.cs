using System.Collections;
using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.PlatForm.BaseData.Service
{
    public class AccountService : AbstractBaseService
    {
        private AccountDao accDao;
        public AccountService()
        {
            accDao = new AccountDao();
            base.Daos = accDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            AccountInfo accInfo = (AccountInfo)baseInfo;
             accDao.AddAccount(accInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            AccountInfo accInfo = (AccountInfo)baseInfo;
             accDao.ModifyAccount(accInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            AccountInfo accInfo = (AccountInfo)baseInfo;
             accDao.DeleteAccount(accInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            AccountInfo accInfo = (AccountInfo)baseInfo;
             accDao.ForbiddenAccount(accInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            AccountInfo accInfo = (AccountInfo)baseInfo;
             accDao.ValueableAccount(accInfo);
        }

        public ArrayList GetForAllGUID()
        {
            return accDao.GetForAllGUID();
        } 

        public DataTable QueryAcctByParent(object cCode)
        {
            return accDao.QueryAcctByParent(cCode);
        }

        public DataTable QueryForAll()
        {
            return accDao.QueryForAll();
        }
    }
}
