using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.ST.Info
{
    public class StockInfo:BusinessMainInfo
    {
        private decimal _iStockAmt;
        private String _cRemark;
        private decimal _iExcRate;
        private String _cDepartment;

        public Decimal iStockAmt
        {
            get { return this._iStockAmt; }
            set { this._iStockAmt = value; }
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
