using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using System.Collections;

namespace TS.Sys.Platform.BaseData.Service
{
    public class MateriaService : AbstractBaseService
    {
        private MateriaDao matDao;
        public MateriaService()
        {
            matDao = new MateriaDao();
            base.Daos = matDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            MateriaInfo matInfo = (MateriaInfo)baseInfo;
             matDao.AddMateria(matInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            MateriaInfo matInfo = (MateriaInfo)baseInfo;
             matDao.ModifyMateria(matInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            MateriaInfo matInfo = (MateriaInfo)baseInfo;
             matDao.DeleteMateria(matInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            MateriaInfo matInfo = (MateriaInfo)baseInfo;
             matDao.ForbiddenMateria(matInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            MateriaInfo matInfo = (MateriaInfo)baseInfo;
             matDao.ValueableMateria(matInfo);
        }


        public DataTable QueryByParent(object Parent)
        {
            return matDao.QueryByParent(Parent);
        }

        public ArrayList GetAllList()
        {
            return matDao.GetResultList(null);
        }
 
    }
}
