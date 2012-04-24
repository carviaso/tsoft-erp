using System.Data;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;  
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.BaseData.Service
{
    public class RegionService : AbstractBaseService
    {
        private RegionDao rgDao;
        public RegionService()
        {
            rgDao = new RegionDao();
            base.Daos = rgDao;
        }
        public override void Add(BaseInfo baseInfo)
        {
            RegionInfo regionInfo = (RegionInfo)baseInfo;
            rgDao.AddRegion(regionInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            RegionInfo regionInfo = (RegionInfo)baseInfo;
             rgDao.ModifyRegion(regionInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            RegionInfo regionInfo = (RegionInfo)baseInfo;
             rgDao.DeleteRegion(regionInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            RegionInfo regionInfo = (RegionInfo)baseInfo;
             rgDao.ForbiddenRegion(regionInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            RegionInfo regionInfo = (RegionInfo)baseInfo;
             rgDao.ValueableRegion(regionInfo);
        }
          
        public DataTable QueryForAll()
        {
            return rgDao.QueryForAll();
        }
    }
}
