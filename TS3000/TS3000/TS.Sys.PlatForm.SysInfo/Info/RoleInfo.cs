using TS.Sys.Platform.Business.Info;
using System.Collections;

namespace TS.Sys.Platform.SysInfo.Info
{
    public class RoleInfo:BaseInfo
    {
        private object _cParent;
        private ArrayList _Secu;
        private ArrayList _BtnSecu;

        public ArrayList BtnSecu
        {
            get { return this._BtnSecu; }
            set { this._BtnSecu = value; }
        }

        /// <summary>
        /// 权限列表
        /// </summary>
        public ArrayList Secu
        {
            get { return this._Secu; }
            set { this._Secu = value; }
        }

        public object cParent
        {
            get { return this._cParent; }
            set { this._cParent = value; }
        }
    }
}
