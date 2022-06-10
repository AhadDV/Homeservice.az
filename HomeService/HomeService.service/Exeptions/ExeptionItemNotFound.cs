using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Exeptions
{
   public class ExeptionItemNotFound:Exception
    {
        public ExeptionItemNotFound(string msg):base(msg)
        {

        }
    }
}
