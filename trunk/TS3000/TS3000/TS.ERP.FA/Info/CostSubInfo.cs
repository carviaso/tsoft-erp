using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Platform.Business.Info;

namespace TS.ERP.FA.Info
{
    public class CostSubInfo : BusinessSubInfo
    {
        private String _cCostType;
        private decimal _iDetailCostAmt;
        private String _cDetailRemark;

        public String cCostType
        {
            get { return this._cCostType; }
            set { this._cCostType = value; }
        }

        public Decimal iDetailCostAmt
        {
            get { return this._iDetailCostAmt; }
            set { this._iDetailCostAmt = value; }
        }

        public String cDetailRemark
        {
            get { return this._cDetailRemark; }
            set { this._cDetailRemark = value; }
        }
    }
}
