using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TS.Sys.Platform.Business.Forms
{
    public interface IFormEvents
    {
         void New();

         void Add();

         void Modify();

         void Delete();
    }
}
