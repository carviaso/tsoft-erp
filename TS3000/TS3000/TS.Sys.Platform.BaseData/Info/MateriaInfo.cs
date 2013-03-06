using System; 
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.BaseData.Info
{
    public class MateriaInfo : BaseInfo
    {
        private object _cFullName;
        private object _cShortName;
        private object _cUnit;
        private object _iInPrice;
         

        public Object cFullName
        {
            get { return _cFullName; }
            set { this._cFullName = value; }
        }

        public Object cShortName
        {
            get { return _cShortName; }
            set { this._cShortName = value; }
        }

    }
}
