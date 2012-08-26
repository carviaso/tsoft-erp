using System;
using System.Collections;
using TS.Sys.Platform.SysInfo.Dao;

namespace TS.Sys.Platform.SysInfo.Service
{
    public class ButtonService
    {
        private ButtonDao btnDao;

        public ButtonService()
        {
            btnDao = new ButtonDao();
        }
        public ArrayList GetBtnList(Object cParent)
        {
            return btnDao.GetBtnList(cParent);
        }
    }
}
