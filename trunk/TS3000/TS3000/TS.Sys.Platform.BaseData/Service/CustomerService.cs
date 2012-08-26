using System.Data;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Dao;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using System.Collections;

namespace TS.Sys.Platform.BaseData.Service
{
    public class CustomerService : AbstractBaseService
    {
        private CustomerDao custDao;
        public CustomerService()
        {
            custDao = new CustomerDao();
            base.Daos = custDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            CustomerInfo custInfo = (CustomerInfo)baseInfo;
             custDao.AddCustomer(custInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            CustomerInfo custInfo = (CustomerInfo)baseInfo;
             custDao.ModifyCustomer(custInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            CustomerInfo custInfo = (CustomerInfo)baseInfo;
             custDao.DeleteCustomer(custInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            CustomerInfo custInfo = (CustomerInfo)baseInfo;
             custDao.ForbiddenCustomer(custInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            CustomerInfo custInfo = (CustomerInfo)baseInfo;
             custDao.ValueableCustomer(custInfo);
        }
         

        public DataTable QueryByRegion(object cRegion)
        {
            return custDao.QueryByRegion(cRegion);
        }

        public ArrayList GetAllList()
        {
            return custDao.GetResultList(null);
        }
 
    }
}
