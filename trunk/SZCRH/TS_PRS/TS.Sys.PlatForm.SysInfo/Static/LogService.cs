using System;
using System.Collections;
using TS.Sys.DBLayer;
using TS.Sys.Session;

namespace TS.Sys.Platform.SysInfo.Static
{
    public class LogService
    {
        private static LogService log;
        private LogService() { }

        public static LogService GetInstance()
        {
            if (log != null)
                return log;
            else
                return new LogService();
        }

        public void Info(String cAction,String cModual)
        {
            Hashtable con = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            con.Add("cGUID", cGUID);
            con.Add("dDateTime", DateTime.Now);
            con.Add("cAction", cAction);
            con.Add("cModualName", cModual);
            con.Add("cRoleName", UserSession.RoleName);
            con.Add("cUserName", UserSession.UserName);
            DbSvr.GetDbService().Insert("Sys_Log", con);
        }
    }
}
