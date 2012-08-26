using System; 

namespace TS.Sys.Domain
{
    public class Result
    {
        private int _iCode;
        private string _cMessage;
        private string _cException;

        public int Code
        {
            get { return this._iCode; }
            set { this._iCode = value; }
        }

        public String Message
        {
            get { return this._cMessage; }
            set { this._cMessage = value; }
        }

        public String Exception
        {
            get { return this._cException; }
            set { this._cException = value; }
        }
    }
}
