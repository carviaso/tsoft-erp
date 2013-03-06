using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.ST.Info
{
    public class SaOutSubInfo : BusinessSubInfo
    {
        private String _cSaOutType;
        private decimal _iDetailSaOutAmt;
        private String _cDetailRemark;

        public String cSaOutType
        {
            get { return this._cSaOutType; }
            set { this._cSaOutType = value; }
        }

        public Decimal iDetailSaOutAmt
        {
            get { return this._iDetailSaOutAmt; }
            set { this._iDetailSaOutAmt = value; }
        }

        public String cDetailRemark
        {
            get { return this._cDetailRemark; }
            set { this._cDetailRemark = value; }
        }
    }
}
