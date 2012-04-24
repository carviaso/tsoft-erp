using System;
using System.Collections.Generic;
using System.Text;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Domain;

namespace TS.Sys.Util
{
    public class NumberUtil
    {
        public static Decimal GetAmt(String o)
        {
            char c = o[0];
            if (c.Equals('-'))
            {
                o = o.Substring(2);
                o = "-" + o;
            }
            else
                o = o.Substring(1);
            
            Decimal amt = Decimal.Parse(o);
            return amt;
        }

        public static String FormatAMT(Object amtIn)
        {
            try
            {
                //Decimal amt = Decimal.Parse(amtIn.ToString().Trim());
                return string.Format("{0:N}",amtIn);
                
            }
            catch (Exception ex)
            {
                throw new BusinessException(ExceptionConst.Error_Number);
            }

        }

         
    }
}
