using System.Collections; 
using TS.Sys.Platform.Business.Dao;

namespace TS.Sys.Platform.Business.Service
{
    public class Services
    {
        private Daos _dao;

        public Daos Daos
        {
            get { return this._dao; }
            set { this._dao = value; }
        }

        public BusinessDao BusinessDao
        {
            get { return (BusinessDao)this._dao; }
        }

        public BaseDao BaseDao
        {
            get { return (BaseDao)this._dao; }
        }

        public ArrayList GetMainResult(object cGUID)
        {
            return _dao.GetMainResult(cGUID);
        }


    }
}
