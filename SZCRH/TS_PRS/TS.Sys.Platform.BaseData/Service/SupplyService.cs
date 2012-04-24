using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
namespace TS.Sys.Platform.BaseData.Service
{
    public class SupplyService : AbstractBaseService
    {
        private SupplyDao spDao;
        public SupplyService()
        {
            spDao = new SupplyDao();
            base.Daos = spDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            SupplyInfo supInfo = (SupplyInfo)baseInfo;
             spDao.AddSupply(supInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            SupplyInfo supInfo = (SupplyInfo)baseInfo;
             spDao.ModifySupply(supInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            SupplyInfo supInfo = (SupplyInfo)baseInfo;
             spDao.DeleteSupply(supInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            SupplyInfo supInfo = (SupplyInfo)baseInfo;
            spDao.ForbiddenSupply(supInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            SupplyInfo supInfo = (SupplyInfo)baseInfo;
             spDao.ValueableSupply(supInfo);
        }
         

        public DataTable QueryByRegion(object cRegion)
        {
            return spDao.QueryByRegion(cRegion);
        }
               
    }
}
