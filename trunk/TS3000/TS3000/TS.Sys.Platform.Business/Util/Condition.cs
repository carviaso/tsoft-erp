using System.Collections;
using System; 

namespace TS.Sys.Platform.Business.Util
{
    
    public class Condition
    {
        private Hashtable param;

        public Condition()
        {
            param = new Hashtable();
        }

        public void  AddParam(String name,object value)
        {
            param.Add(name, value);
        }

        public Hashtable GetParam()
        {
            return this.param;
        }

        public void UpdateParam(String name, object value)
        {
            param[name] = value;
        }

        public void RemoveParam(String name)
        {
            param.Remove(name);
        }

        public Boolean IndexContidionName(String name)
        {
            return param.ContainsKey(name);
        }
    }
}
