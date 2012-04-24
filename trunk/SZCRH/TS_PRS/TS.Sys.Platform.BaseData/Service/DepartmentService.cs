using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.BaseData.Service
{
    public class DepartmentService : AbstractBaseService
    {
        private DepartmentDao deptDao;

        public DepartmentService()
        {
            deptDao = new DepartmentDao();
            base.Daos = deptDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            DepartmentInfo deptInfo = (DepartmentInfo)baseInfo;            
            deptDao.AddDepartment(deptInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            DepartmentInfo deptInfo = (DepartmentInfo)baseInfo;
             deptDao.ModifyDepartment(deptInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            DepartmentInfo deptInfo = (DepartmentInfo)baseInfo;
             deptDao.DeleteDepartment(deptInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            DepartmentInfo deptInfo = (DepartmentInfo)baseInfo;
             deptDao.ForbiddenDepartment(deptInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            DepartmentInfo deptInfo = (DepartmentInfo)baseInfo;
             deptDao.ValueableDepartment(deptInfo);
        }

        public DataTable QueryTreeResult(object cGUID)
        {
            return deptDao.QueryTreeResult(cGUID);
        }

        public DataTable QueryForAll()
        {
            return deptDao.QueryForAll();
        } 
    }
}
