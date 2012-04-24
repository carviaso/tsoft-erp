using System;
using System.Collections.Generic;
using System.Text;

namespace TS.Sys.Util
{
    public class BusinessKey
    {
        private static BusinessKey businessKey;

        private static int CONST_NUMBER;
        private static string DATE;

        private BusinessKey()
        {
            CONST_NUMBER = 0;
            DATE = DateTime.Now.ToString("yyyyMMdd");
        }

        public static BusinessKey GetBusinessKey()
        {
            if (businessKey == null) businessKey = new BusinessKey();
            return businessKey;
        }
         


        public string GetBusinessCode(string prefix,int level)
        {
            if (!DateTime.Now.ToString("yyyyMMdd").Equals(DATE))
            {
                DATE = DateTime.Now.ToString("yyyyMMdd");
                CONST_NUMBER = 0;
            }
            CONST_NUMBER++;

            String number = CONST_NUMBER.ToString().PadLeft(level, '0');
            return (prefix == null ? "" : prefix) + DATE+number;
        }
    }
}
