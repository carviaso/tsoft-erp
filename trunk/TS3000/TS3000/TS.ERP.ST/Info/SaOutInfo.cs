using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.ST.Info
{
    public class SaOutInfo:BusinessMainInfo
    {
        private decimal _iSaOutAmt;
        private String _cRemark;
        private decimal _iExcRate;
        private String _cDepartment;

        public Decimal iSaOutAmt
        {
            get { return this._iSaOutAmt; }
            set { this._iSaOutAmt = value; }
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
