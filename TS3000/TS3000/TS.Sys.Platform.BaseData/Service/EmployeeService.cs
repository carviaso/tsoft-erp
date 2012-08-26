using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;

namespace TS.Sys.Platform.BaseData.Service
{
    public class EmployeeService : AbstractBaseService
    {
        private EmployeeDao empDao;

        public EmployeeService()
        {
            empDao = new EmployeeDao();
            base.Daos = empDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            EmployeeInfo empInfo = (EmployeeInfo)baseInfo;
             empDao.AddEmployee(empInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            EmployeeInfo empInfo = (EmployeeInfo)baseInfo;
             empDao.ModifyEmployee(empInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            EmployeeInfo empInfo = (EmployeeInfo)baseInfo;
             empDao.DeleteEmployee(empInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            EmployeeInfo empInfo = (EmployeeInfo)baseInfo;
             empDao.ForbiddenEmployee(empInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            EmployeeInfo empInfo = (EmployeeInfo)baseInfo;
             empDao.ValueableEmployee(empInfo);
        }

        public DataTable QueryForAll()
        {
            return empDao.QueryForAll();
        }

        public DataTable QueryByDepartment(object cDepartment)
        {
            return empDao.QueryByDepartment(cDepartment);
        } 
    }
}
