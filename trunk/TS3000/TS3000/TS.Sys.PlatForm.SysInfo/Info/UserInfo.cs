using System;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.SysInfo.Info
{
    public class UserInfo:BaseInfo
    {
        private object _cEmployee;
        private object _cRole;

        public Object cRole
        {
            get{return this._cRole;}
            set{this._cRole = value;}
        }

        public Object cEmployee
        {
            get { return this._cEmployee; }
            set { this._cEmployee = value; }
        }
    }
}
