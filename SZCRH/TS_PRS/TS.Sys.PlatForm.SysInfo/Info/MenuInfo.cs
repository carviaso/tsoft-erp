using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.SysInfo.Info
{
    public class MenuInfo : BaseInfo
    {
        private object _cTitle;
        private object _cParent;
        private object _cForm;
        private object _cField;

        public Object cTitle
        {
            get { return _cTitle; }
            set { this._cTitle = value; }
        }

        public Object cParent
        {
            get { return _cParent; }
            set { this._cParent = value; }
        }

        public Object cForm
        {
            get { return this._cForm; }
            set { this._cForm = value; }
        }
    }
}
