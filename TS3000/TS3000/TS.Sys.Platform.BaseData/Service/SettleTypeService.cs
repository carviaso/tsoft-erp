using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.BaseData.Service
{
    public class SettleTypeService : AbstractBaseService
    {
        private SettleTypeDao stDao;

        public SettleTypeService()
        {
            stDao = new SettleTypeDao();
            base.Daos = stDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            SettleTypeInfo settleInfo = (SettleTypeInfo)baseInfo;
             stDao.AddSettleType(settleInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            SettleTypeInfo settleInfo = (SettleTypeInfo)baseInfo;
             stDao.ModifySettleType(settleInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            SettleTypeInfo settleInfo = (SettleTypeInfo)baseInfo;
             stDao.DeleteSettleType(settleInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            SettleTypeInfo settleInfo = (SettleTypeInfo)baseInfo;
             stDao.ForbiddenSettleType(settleInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            SettleTypeInfo settleInfo = (SettleTypeInfo)baseInfo;
             stDao.ValueableSettleType(settleInfo);
        }

        public DataTable QueryAll()
        {
            return stDao.QueryForAll();
        } 
    }
}
