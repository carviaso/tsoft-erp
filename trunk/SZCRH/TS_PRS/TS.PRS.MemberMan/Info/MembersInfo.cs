using System;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Info;

namespace TS.PRS.MemberMan.Info
{
    public class MembersInfo:BaseInfo
    {
        private object _cCompany;
        private object _cRecomMember;
        private object _dRecommendDate;         
        private object _cId; 
      

        public Object cCompany
        {
            get { return this._cCompany; }
            set { this._cCompany = value; }
        }

        
        public Object cRecomMember
        {
            get { return this._cRecomMember; }
            set { this._cRecomMember = value; }
        }

         
        public Object dRecommendDate
        {
            get { return this._dRecommendDate; }
            set { this._dRecommendDate = value; }
        }
         
        public Object cId
        {
            get { return this._cId; }
            set { this._cId = value; }
        }

        
    }
}
