﻿using System;
using TS.Sys.Platform.Business.Info;

namespace TS.PRS.MemberMan.Info
{
    public class MembersSalaryInfo : BusinessMainInfo
    {
        private object _iMemberNum;
        private object _iMemberSalarySum;
        private object _dDate;
        private object _cDepartment;
        private object _cRemark;

        public Object cRemark
        {
            get { return this._cRemark; }
            set { this._cRemark = value; }
        }

        public Object cDepartment
        {
            get { return this._cDepartment; }
            set { this._cDepartment = value; }
        }

        public Object dDate
        {
            get { return this._dDate; }
            set { this._dDate = value; }
        }

        public Object iMemberNum
        {
            get { return this._iMemberNum; }
            set { this._iMemberNum = value; }
        }

        public Object iMemberSalarySum
        {
            get { return this._iMemberSalarySum; }
            set { this._iMemberSalarySum = value; }
        }
    }
}
