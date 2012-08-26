using System;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Session;
using System.Collections;

namespace TS.Sys.Platform.SecuAccess
{
    public class FunctionAccess
    {
        public static void Access(String btnName,String form)
        {
            form = form.Substring(0, form.Length - 4);
            ArrayList result = DbSvr.GetDbService().GetListResult("select 1 from Sys_RoleBtnSecu where cRole = '"+UserSession.RoleID+"' and cBtnSecu = '"+btnName+"' and cModual='"+form+"'");
            if (result == null || result.Count == 0)
            {
                throw new BusinessException("对不起，您没有该操作的权限！");
            }
        }
    }
}
