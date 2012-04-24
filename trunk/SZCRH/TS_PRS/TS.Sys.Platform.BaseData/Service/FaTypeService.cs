using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.BaseData.Service
{
    public class FaTypeService : AbstractBaseService
    {
        private FaTypeDao ftDao;

        public FaTypeService()
        {
            ftDao = new FaTypeDao();
            base.Daos = ftDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            FaTypeInfo fatypeInfo = (FaTypeInfo)baseInfo;
             ftDao.AddFaType(fatypeInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            FaTypeInfo fatypeInfo = (FaTypeInfo)baseInfo;
             ftDao.ModifyFaType(fatypeInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            FaTypeInfo fatypeInfo = (FaTypeInfo)baseInfo;
             ftDao.DeleteFaType(fatypeInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            FaTypeInfo fatypeInfo = (FaTypeInfo)baseInfo;
             ftDao.ForbiddenFaType(fatypeInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            FaTypeInfo fatypeInfo = (FaTypeInfo)baseInfo;
             ftDao.ValueableFaType(fatypeInfo);
        }

        public DataTable QueryByType(object con)
        {
            return ftDao.QueryByType(con);
        } 
    }
}
