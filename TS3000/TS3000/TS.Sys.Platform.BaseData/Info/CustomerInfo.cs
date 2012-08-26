using System; 
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.BaseData.Info
{
    public class CustomerInfo : BaseInfo
    {
        private object _cFullName;
        private object _cShortName;
        private object _cAddress;
        private object _cZip;
        private object _cRegion;
        private object _cContactor;
        private object _cPhone;
        private object _cFax;
        private object _cBank;
        private object _cBankAccount;
         

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

        public Object cAddress
        {
            get { return _cAddress; }
            set { this._cAddress = value; }
        }

        public Object cZip
        {
            get { return _cZip; }
            set { this._cZip = value; }
        }

        public Object cRegion
        {
            get { return _cRegion; }
            set { this._cRegion = value; }
        }

        public Object cContactor
        {
            get { return _cContactor; }
            set { this._cContactor = value; }
        }

        public Object cPhone
        {
            get { return _cPhone; }
            set { this._cPhone = value; }
        }

        public Object cFax
        {
            get { return _cFax; }
            set { this._cFax = value; }
        }

        public Object cBank
        {
            get { return _cBank; }
            set { this._cBank = value; }
        }

        public Object cBankAccount
        {
            get { return _cBankAccount; }
            set { this._cBankAccount = value; }
        }
    }
}
