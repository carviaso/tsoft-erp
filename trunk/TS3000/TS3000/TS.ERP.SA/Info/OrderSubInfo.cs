using System;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.SA.Info
{
    public class OrderSubInfo : BusinessSubInfo
    {
        private String _cMateriaCode;
        private int _iNum;
        private int _iAmt;
        private decimal _iPrice;
        private double _iDiscount;

        public String cMateriaCode
        {
            get { return this._cMateriaCode; }
            set { this._cMateriaCode = value; }
        }

        public int iNum
        {
            get { return this._iNum; }
            set { this._iNum = value; }
        }

        public int iAmt
        {
            get { return this._iAmt; }
            set { this._iAmt = value; }
        }

        public Decimal iPrice
        {
            get { return this._iPrice; }
            set { this._iPrice = value; }
        }

        public Double iDiscount
        {
            get { return this._iDiscount; }
            set { this._iDiscount = value; }
        }
    }
}
