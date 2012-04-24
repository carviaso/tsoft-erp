using System;  

namespace TS.Sys.Platform.Business.Info
{
    public class BaseInfo:Infos
    {

        private object _cCode;
        private object _cName;
        private object _cParent;
        private object _iForbidden = 0;

        public Object cCode
        {
            get { return this._cCode; }
            set { this._cCode = value; }
        }

        public Object cName
        {
            get { return this._cName; }
            set { this._cName = value; }
        }

        public Object cParent
        {
            get { return this._cParent; }
            set { this._cParent = value; }
        }

        public Object iForbidden
        {
            get { return this._iForbidden; }
            set { this._iForbidden = value; }
        }
    }
}
