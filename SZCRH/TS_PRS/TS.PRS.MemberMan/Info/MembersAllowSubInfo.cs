using System;
using TS.Sys.Platform.Business.Info;

namespace TS.PRS.MemberMan.Info
{
    public class MembersAllowSubInfo : BusinessSubInfo
    {
        private object _cMemberCode;
        private object _iMemberAllow;
        private object _cMemberName;
        private object _iRecNum;
        private object _iTeamNum;

        public Object cMemberCode
        {
            get { return this._cMemberCode; }
            set { this._cMemberCode = value; }
        }

        public Object iMemberAllow
        {
            get { return this._iMemberAllow; }
            set { this._iMemberAllow = value; }
        }

        public Object cMemberName
        {
            get { return this._cMemberName; }
            set { this._cMemberName = value; }
        }

        public Object iRecNum
        {
            get { return this._iRecNum; }
            set { this._iRecNum = value; }
        }

        public Object iTeamNum
        {
            get { return this._iTeamNum; }
            set { this._iTeamNum = value; }
        }
    }
}
