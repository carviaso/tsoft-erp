using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.FA.Info
{
    public class RevenInfo:BusinessMainInfo
    {
        private decimal _iRevenAmt;
        private String _cRemark;
        private decimal _iExcRate;
        private String _cDepartment;

        public Decimal iRevenAmt
        {
            get { return this._iRevenAmt; }
            set { this._iRevenAmt = value; }
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
