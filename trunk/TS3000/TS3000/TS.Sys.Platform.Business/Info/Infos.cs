using System;

namespace TS.Sys.Platform.Business.Info
{
    public class Infos
    {
        private object _cGUID;
        private object _cTimeStamp;
        
        public Object cGUID
        {
            get { return this._cGUID; }
            set { this._cGUID = value; }
        }

        

        public Object cTimeStamp
        {
            get { return this._cTimeStamp; }
            set { this._cTimeStamp = value; }
        }

    }
}
