using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.DBLayer;

namespace TS.Sys.Platform.SysInfo.Service
{
    public class SecurityService
    {
        public void SecuValidation(String btnName)
        {
            DbSvr.GetDbService().GetListResult("select 1 from ");
        }
    }
}
