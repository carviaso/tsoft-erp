using System; 
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class AccountInfo:BaseInfo
    {
        private object _cShortCode;
         
        public Object cShortCode
        {
            get { return this._cShortCode; }
            set { this._cShortCode = value; }
        }
    }
}
