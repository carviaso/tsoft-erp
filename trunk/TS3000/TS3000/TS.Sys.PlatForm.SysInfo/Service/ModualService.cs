using System.Collections;
using TS.Sys.Platform.SysInfo.Dao;

namespace TS.Sys.Platform.SysInfo.Service
{
    public class ModualService
    {
        private ModualDao modualDao;

        public ModualService()
        {
            modualDao = new ModualDao();
        }

        public ArrayList GetResultList(object con)
        {
            return modualDao.GetResultList(con);
        }
    }
}
