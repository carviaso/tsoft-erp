using System.Collections;
using System.Data;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.BaseData.Service
{
    public class StorageService : AbstractBaseService
    {
        private StorageDao storeDao;
        public StorageService()
        {
            storeDao = new StorageDao();
            base.Daos = storeDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            StorageInfo storeInfo = (StorageInfo)baseInfo;
             storeDao.AddStorage(storeInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            StorageInfo storeInfo = (StorageInfo)baseInfo;
             storeDao.ModifyStorage(storeInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            StorageInfo storeInfo = (StorageInfo)baseInfo;
             storeDao.DeleteStorage(storeInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            StorageInfo storeInfo = (StorageInfo)baseInfo;
             storeDao.ForbiddenStorage(storeInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            StorageInfo storeInfo = (StorageInfo)baseInfo;
             storeDao.ValueableStorage(storeInfo);
        }
         

        public DataTable QueryByParent(object cParent)
        {
            return storeDao.QueryByParent(cParent);
        }

        public ArrayList GetAllList()
        {
            return storeDao.GetResultList(null);
        }
 
    }
}
