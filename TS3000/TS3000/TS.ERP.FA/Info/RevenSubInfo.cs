using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.FA.Info
{
    public class RevenSubInfo : BusinessSubInfo
    {
        private String _cRevenType;
        private decimal _iDetailRevenAmt;
        private String _cDetailRemark;

        public String cRevenType
        {
            get { return this._cRevenType; }
            set { this._cRevenType = value; }
        }

        public Decimal iDetailRevenAmt
        {
            get { return this._iDetailRevenAmt; }
            set { this._iDetailRevenAmt = value; }
        }

        public String cDetailRemark
        {
            get { return this._cDetailRemark; }
            set { this._cDetailRemark = value; }
        }
    }
}
