using System;
using TS.Sys.Platform.Business.Info;

namespace TS.PRS.MemberMan.Info
{
    public class MembersSalarySubInfo : BusinessSubInfo
    {
        private object _cMemberCode;
        private object _cMemberName;
        private object _iMemberSalary;
        private object _cMemberId;
        private object _iDayNumPersonCurrMon;
        private object _iDayNumDeptCurrMon;
        private object _iDayNumPersonLastMon;
        private object _iDayNumDeptLastMon;
        private object _iOvertimeSum_workday;
        private object _iOvertimeSum_holiday;
        private object _iOvertimeSum_festival;
        private object _iOvertimeSum_allow;
        private object _iOwetimeSum;
        private object _iAwaytimeSum;
        private object _iOfftimeSum;
        private object _iBaseSalary;
        private object _iOvertimeFeeSum;
        private object _iNighttimeAllowSum;
        private object _iOwetimeFeeSum;
        private object _iSalarySum;
        private object _iDayNum;
        private object _iElectriBill;
        private object _iWaterBill;
        private object _iGasBill;
        private object _iAccidentInsure;
        private object _iDormBill;
        private object _iBillSum;
        private object _iPrePay;
        private object _iRecomBill;
        private object _iCutManPay;
        private object _iCutCertifyPay;
        private object _iCutEduPay; 
        private object _cSalaryRemark; 


        public Object cMemberCode
        {
            get { return this._cMemberCode; }
            set { this._cMemberCode = value; }
        }

        public Object cMemberName
        {
            get { return this._cMemberName; }
            set { this._cMemberName = value; }
        }

        public Object iMemberSalary
        {
            get { return this._iMemberSalary; }
            set { this._iMemberSalary = setZero(value); }
        }

        public Object cMemberId
        {
            get { return this._cMemberId; }
            set { this._cMemberId = value; }
        }

        public Object iDayNumPersonCurrMon
        {
            get { return this._iDayNumPersonCurrMon; }
            set { this._iDayNumPersonCurrMon = setZero(value); }
        }

        public Object iDayNumDeptCurrMon
        {
            get { return this._iDayNumDeptCurrMon; }
            set { this._iDayNumDeptCurrMon = setZero(value); }
        }


        public Object iDayNumPersonLastMon
        {
            get { return this._iDayNumPersonLastMon; }
            set { this._iDayNumPersonLastMon = setZero(value); }
        }

        public Object iDayNumDeptLastMon
        {
            get { return this._iDayNumDeptLastMon; }
            set { this._iDayNumDeptLastMon = setZero(value); }
        }

        public Object iOvertimeSum_workday
        {
            get { return this._iOvertimeSum_workday; }
            set { this._iOvertimeSum_workday = setZero(value); }
        }

        public Object iOvertimeSum_holiday
        {
            get { return this._iOvertimeSum_holiday; }
            set { this._iOvertimeSum_holiday = setZero(value); }
        }


        public Object iOvertimeSum_festival
        {
            get { return this._iOvertimeSum_festival; }
            set { this._iOvertimeSum_festival = setZero(value); }
        }

        public Object iOvertimeSum_allow
        {
            get { return this._iOvertimeSum_allow; }
            set { this._iOvertimeSum_allow = setZero(value); }
        }

        public Object iOwetimeSum
        {
            get { return this._iOwetimeSum; }
            set { this._iOwetimeSum = setZero(value); }
        }

        public Object iAwaytimeSum
        {
            get { return this._iAwaytimeSum; }
            set { this._iAwaytimeSum = setZero(value); }
        }

        public Object iOfftimeSum
        {
            get { return this._iOfftimeSum; }
            set { this._iOfftimeSum = setZero(value); }
        }

        public Object iBaseSalary
        {
            get { return this._iBaseSalary; }
            set { this._iBaseSalary = setZero(value); }
        }

        public Object iOvertimeFeeSum
        {
            get { return this._iOvertimeFeeSum; }
            set { this._iOvertimeFeeSum = setZero(value); }
        }
        
        public Object iNighttimeAllowSum
        {
            get { return this._iNighttimeAllowSum; }
            set { this._iNighttimeAllowSum = setZero(value); }
        }

        public Object iOwetimeFeeSum
        {
            get { return this._iOwetimeFeeSum; }
            set { this._iOwetimeFeeSum = setZero(value); }
        }

        public Object iSalarySum
        {
            get { return this._iSalarySum; }
            set { this._iSalarySum = setZero(value); }
        }

        public Object iDayNum
        {
            get { return this._iDayNum; }
            set { this._iDayNum = setZero(value); }
        }

        public Object iElectriBill
        {
            get { return this._iElectriBill; }
            set { this._iElectriBill = setZero(value); }
        }

        public Object iWaterBill
        {
            get { return this._iWaterBill; }
            set { this._iWaterBill = setZero(value); }
        }

        public Object iGasBill
        {
            get { return this._iGasBill; }
            set { this._iGasBill = setZero(value); }
        }

        public Object iAccidentInsure
        {
            get { return this._iAccidentInsure; }
            set { this._iAccidentInsure = setZero(value); }
        }

        public Object iDormBill
        {
            get { return this._iDormBill; }
            set { this._iDormBill = setZero(value); }
        }

        public Object iBillSum
        {
            get { return this._iBillSum; }
            set { this._iBillSum = setZero(value); }
        }


        public Object iPrePay
        {
            get { return this._iPrePay; }
            set { this._iPrePay = setZero(value); }
        }
        public Object iRecomBill
        {
            get { return this._iRecomBill; }
            set { this._iRecomBill = setZero(value); }
        }
        public Object iCutManPay
        {
            get { return this._iCutManPay; }
            set { this._iCutManPay = setZero(value); }
        }
        public Object iCutCertifyPay
        {
            get { return this._iCutCertifyPay; }
            set { this._iCutCertifyPay = setZero(value); }
        }
        public Object iCutEduPay
        {
            get { return this._iCutEduPay; }
            set { this._iCutEduPay = setZero(value); }
        }
         

        public Object cSalaryRemark
        {
            get { return this._cSalaryRemark; }
            set { this._cSalaryRemark = value; }
        }

        private Object setZero(Object v)
        {
            if (v == null || String.IsNullOrEmpty(v.ToString()))
            {
                return 0;
            }
            return v;
        }


    }
}
