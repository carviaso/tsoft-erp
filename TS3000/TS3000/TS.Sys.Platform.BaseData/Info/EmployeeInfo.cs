using System;
using TS.Sys.Platform.Business.Info; 

namespace TS.Sys.Platform.BaseData.Info
{
    public class EmployeeInfo : BaseInfo
    { 
        private object _cDepartment;
        private object _iSex;
        private object _dBirthDate;
        private object _cPhone;
        private object _cID;
        private object _dEnterDate;
        private object _dExitDate;
        private object _cAddress;
        private object _cBank;
        private object _cBankAccount;
        private object _cEmail;
        private object _cRemark;
 
 

        public Object cDepartment
        {
            get { return this._cDepartment; }
            set { this._cDepartment = value; }
        } 

        public Object iSex
        {
            get { return this._iSex; }
            set { this._iSex = value; }
        }
        public Object dBirthDate
        {
            get { return this._dBirthDate; }
            set { this._dBirthDate = value; }
        }
        public Object cPhone
        {
            get { return this._cPhone; }
            set { this._cPhone = value; }
        }
        public Object cID
        {
            get { return this._cID; }
            set { this._cID = value; }
        }
        public Object dEnterDate
        {
            get { return this._dEnterDate; }
            set { this._dEnterDate = value; }
        }
        public Object dExitDate
        {
            get { return this._dExitDate; }
            set { this._dExitDate = value; }
        }
        public Object cAddress
        {
            get { return this._cAddress; }
            set { this._cAddress = value; }
        }
        public Object cBank
        {
            get { return this._cBank; }
            set { this._cBank = value; }
        }

        public Object cBankAccount
        {
            get { return this._cBankAccount; }
            set { this._cBankAccount = value; }
        }
        public Object cEmail
        {
            get { return this._cEmail; }
            set { this._cEmail = value; }
        }
        public Object cRemark
        {
            get { return this._cRemark; }
            set { this._cRemark = value; }
        }
            
    }
}
