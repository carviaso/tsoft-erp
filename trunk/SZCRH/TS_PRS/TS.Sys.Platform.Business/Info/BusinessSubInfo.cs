using System;

namespace TS.Sys.Platform.Business.Info
{
    public class BusinessSubInfo:Infos
    {
        private object _cHeadGUID;

        public Object cHeadGUID
        {
            get { return this._cHeadGUID; }
            set { this._cHeadGUID = value; }
        }

    }
}
