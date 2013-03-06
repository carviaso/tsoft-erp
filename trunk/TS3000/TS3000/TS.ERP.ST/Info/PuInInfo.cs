using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.ST.Info
{
    public class PuInInfo:BusinessMainInfo
    {
        private decimal _iPuInAmt;
        private String _cRemark;
        private decimal _iExcRate;
        private String _cDepartment;

        public Decimal iPuInAmt
        {
            get { return this._iPuInAmt; }
            set { this._iPuInAmt = value; }
        }

        public String cRemark
        {
            get { return this._cRemark; }
            set { this._cRemark = value; }
        }

        public Decimal iExcRate
        {
            get { return this._iExcRate; }
            set { this._iExcRate = value; }
        }

        public String cDepartment
        {
            get { return this._cDepartment; }
            set { this._cDepartment = value; }
        }
    }
}
