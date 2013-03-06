using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.FA.Info
{
    public class CostInfo:BusinessMainInfo
    {
        private decimal _iCostAmt;
        private String _cRemark;
        private decimal _iExcRate;
        private String _cDepartment;

        public Decimal iCostAmt
        {
            get { return this._iCostAmt; }
            set { this._iCostAmt = value; }
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
