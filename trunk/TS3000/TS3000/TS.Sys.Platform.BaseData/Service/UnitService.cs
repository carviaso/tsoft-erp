using System.Data;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.BaseData.Service
{
    public class UnitService : AbstractBaseService
    {
        private UnitDao unDao;
        public UnitService()
        {
            unDao = new UnitDao();
            base.Daos = unDao;
        }
        public override void Add(BaseInfo baseInfo)
        {
            UnitInfo unitInfo = (UnitInfo)baseInfo;
            unDao.AddUnit(unitInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            UnitInfo unitInfo = (UnitInfo)baseInfo;
             unDao.ModifyUnit(unitInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            UnitInfo unitInfo = (UnitInfo)baseInfo;
             unDao.DeleteUnit(unitInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            UnitInfo unitInfo = (UnitInfo)baseInfo;
             unDao.ForbiddenUnit(unitInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            UnitInfo unitInfo = (UnitInfo)baseInfo;
             unDao.ValueableUnit(unitInfo);
        }
          
        public DataTable QueryForAll()
        {
            return unDao.QueryForAll();
        }
    }
}
