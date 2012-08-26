using System.Collections;
using TS.Sys.Platform.SysInfo.Dao;

namespace TS.Sys.Platform.SysInfo.Service
{
    public class MenuService
    {
        private MenuDao menuDao;

        public MenuService()
        {
            menuDao = new MenuDao();
        }
        public ArrayList GetFlowList(Hashtable con)
        {
            return menuDao.GetFlowList(con);
        }


        public ArrayList GetResultList(Hashtable con)
        {
            return menuDao.GetResultList(con);
        }
    }
}
