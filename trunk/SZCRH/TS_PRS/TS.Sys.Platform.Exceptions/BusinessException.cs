using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Platform.Exceptions.Properties;
using System.Reflection;
using System.Windows.Forms;

namespace TS.Sys.Platform.Exceptions
{
    public class BusinessException : Exception
    {
        //三个共有构造器
        public BusinessException()
            : base()//调用基类的构造器
        {
        }
        public BusinessException(string message)
            : base(message)//调用基类的构造器
        { 
        }
        public BusinessException(string message, Exception innerException)
            : base(message, innerException)//调用基类的构造器
        {
 
        }
    }
}
