using System;

namespace TS.Sys.Domain
{
    [AttributeUsage(AttributeTargets.Property)]
    public class InfosAttributes : Attribute
    {
        public Boolean isDataElement { get; set; }
    }
}
