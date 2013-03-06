using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.ST.Info
{
    public class PuInSubInfo : BusinessSubInfo
    {
        private String _cPuInType;
        private decimal _iDetailPuInAmt;
        private String _cDetailRemark;

        public String cPuInType
        {
            get { return this._cPuInType; }
            set { this._cPuInType = value; }
        }

        public Decimal iDetailPuInAmt
        {
            get { return this._iDetailPuInAmt; }
            set { this._iDetailPuInAmt = value; }
        }

        public String cDetailRemark
        {
            get { return this._cDetailRemark; }
            set { this._cDetailRemark = value; }
        }
    }
}
