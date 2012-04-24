using System.Collections;
using TS.Sys.DBLayer;

namespace TS.Sys.Platform.SysInfo.Dao
{
    public class ButtonDao
    {
        public ArrayList GetBtnList(object cParent)
        {
            Hashtable con = new Hashtable();
            if (cParent != null)
            {
                con.Add("cParent", cParent);
            }
            else
            {
                con.Add("cParent", "cParent");
            }
            return DbSvr.GetDbService().GetListResult("select mb.cCode cBtnCode,mb.cName cBtnName,m.cName cModualName,m.cCode cModualCode from Sys_SysModualBtn mb inner join Sys_SysMenu m on mb.cParent = m.cCode where mb.cParent=@cParent", con);
        }
    }
}
