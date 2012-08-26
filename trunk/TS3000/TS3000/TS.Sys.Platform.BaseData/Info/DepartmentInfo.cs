using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class DepartmentInfo:BaseInfo
    {
        private object _cFullName; 
        private object _cRemark;    

        public Object cFullName
        {
            get { return this._cFullName; }
            set { this._cFullName = value; }
        }
         

        public Object cRemark
        {
            get { return this._cRemark; }
            set { this._cRemark = value; }
        }
    }
}
