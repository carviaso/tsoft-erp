using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.SA.Info
{
    public class OrderInfo:BusinessMainInfo
    {
        private decimal _iOrderAmt;
        private String _cRemark;
        private decimal _iExcRate;
        private String _cDepartment;

        public Decimal iOrderAmt
        {
            get { return this._iOrderAmt; }
            set { this._iOrderAmt = value; }
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
