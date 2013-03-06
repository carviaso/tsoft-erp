using System.Data;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.BaseData.Service
{
    public class MateriaClassService : AbstractBaseService
    {
        private MateriaClassDao mcDao;

        public MateriaClassService()
        {
            mcDao = new MateriaClassDao();
            base.Daos = mcDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            MateriaClassInfo fatypeInfo = (MateriaClassInfo)baseInfo;
             mcDao.AddMateriaClass(fatypeInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            MateriaClassInfo fatypeInfo = (MateriaClassInfo)baseInfo;
             mcDao.ModifyMateriaClass(fatypeInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            MateriaClassInfo fatypeInfo = (MateriaClassInfo)baseInfo;
             mcDao.DeleteMateriaClass(fatypeInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            MateriaClassInfo fatypeInfo = (MateriaClassInfo)baseInfo;
             mcDao.ForbiddenMateriaClass(fatypeInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            MateriaClassInfo fatypeInfo = (MateriaClassInfo)baseInfo;
             mcDao.ValueableMateriaClass(fatypeInfo);
        }

        public DataTable QueryByType(object con)
        {
            return mcDao.QueryByType(con);
        } 
    }
}
