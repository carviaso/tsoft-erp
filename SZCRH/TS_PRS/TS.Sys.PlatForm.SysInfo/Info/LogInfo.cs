using System;

namespace TS.Sys.Platform.SysInfo.Info
{
    public class LogInfo
    {
        private object _cGUID;
        private object _dDateTime;
        private object _cAction;
        private object _cUserName;
        private object _cRoleName;
        private object _cModulalName;

        public Object cGUID
        {
            get { return this._cGUID; }
            set { this._cGUID = value; }
        }

        public Object dDateTime
        {
            get { return this._dDateTime; }
            set { this._dDateTime = value; }
        }

        public Object cAction
        {
            get { return this._cAction; }
            set { this._cAction = value; }
        }

        public Object cRoleName
        {
            get { return this._cRoleName; }
            set { this._cRoleName = value; }
        }

        public Object cModualName
        {
            get { return this._cModulalName; }
            set { this._cModulalName = value; }
        }
    }
}
