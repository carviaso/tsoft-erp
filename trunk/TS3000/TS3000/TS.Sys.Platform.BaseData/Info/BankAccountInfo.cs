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
        private object _cAccount;

        public Object cBank
        {
            get { return this._cBank; }
            set { this._cBank = value; }
        }

        public Object cAccount
        {
            get { return this._cAccount; }
            set { this._cAccount = value; }
        }
    }
}
