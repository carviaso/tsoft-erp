using System;
using System.Collections;

namespace TS.Sys.Platform.Business.Info
{
    public class BusinessMainInfo:Infos
    {
        private object _cCode;
        private object _cAuditor;
        private object _dAuditDate;
        private object _cCreator;
        private ArrayList _subInfos;

        public Object cCode
        {
            get { return this._cCode; }
            set { this._cCode = value; }
        }

        
        public Object cAuditor
        {
            get { return this._cAuditor; }
            set { this._cAuditor = value; }
        }

        public Object dAuditDate
        {
            get { return this._dAuditDate; }
            set { this._dAuditDate = value; }
        }

        public Object cCreator
        {
            get { return this._cCreator; }
            set { this._cCreator = value; }
        }

        public ArrayList SubInfos
        {
            get { return this._subInfos; }
            set { this._subInfos = value; }
        }

    }
}
