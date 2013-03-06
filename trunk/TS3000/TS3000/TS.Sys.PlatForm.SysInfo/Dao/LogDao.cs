using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.DBLayer;
using System.Collections;
using TS.Sys.Platform.SysInfo.Info;

namespace TS.Sys.Platform.SysInfo.Dao
{
    public class LogDao
    {
        public void AddLog(LogInfo logInfo)
        {
            Hashtable con = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            con.Add("cGUID",cGUID);
            con.Add("dDateTime",logInfo.dDateTime);
            con.Add("cAction", logInfo.cAction);
            con.Add("cModualName",logInfo.cModualName);
            con.Add("cRoleName", logInfo.cRoleName);
            DbSvr.GetDbService().Insert("Sys_Log", con);
        }
    }
}
