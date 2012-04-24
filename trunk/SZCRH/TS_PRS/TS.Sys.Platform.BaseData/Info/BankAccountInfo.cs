using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.BaseData.Info
{
    public class BankAccountInfo:BaseInfo
    {
        private object _cBank;
        private object _cBankAcct;

        public Object cBank
        {
            get { return this._cBank; }
            set { this._cBank = value; }
        }

        public Object cBankAcct
        {
            get { return this._cBankAcct; }
            set { this._cBankAcct = value; }
        }
    }
}
