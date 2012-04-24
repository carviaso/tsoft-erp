using System;
using System.Collections.Generic;
using System.Text;

namespace TS.Sys.Util
{
    public class KeyUtil
    {
        /// <summary>
        /// 生成18位唯一ID
        /// </summary>
        /// <returns></returns>
        public static String genSimpleKey()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return Convert.ToString(BitConverter.ToInt64(buffer, 0)).Substring(1);   
        }

        /// <summary>
        /// 生成“前缀+YYYYMMDD+两位随机数”的编码
        /// </summary>
        /// <param name="prefix">前缀</param>
        /// <returns></returns>
        public static String genSimpleCode(String prefix)
        {
            return (prefix==null?"":prefix) + DateTime.Now.ToString("yyyyMMdd") + new Random().Next(10, 100);
        }
    }
}
