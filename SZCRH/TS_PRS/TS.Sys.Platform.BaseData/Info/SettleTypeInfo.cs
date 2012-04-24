using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class SettleTypeInfo : BaseInfo
    {
        private object _cAcctGUID; 

        public Object cAcctGUID
        {
            get { return this._cAcctGUID; }
            set { this._cAcctGUID = value; }
        } 
    
        
    }
}
