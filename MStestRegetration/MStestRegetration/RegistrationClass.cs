using System;
using System.Collections.Generic;
using System.Text;

namespace MStestRegetration
{
   public class RegistrationClass
    {
        public string GETName(string firstname, string lastname)
        {
            return string.Concat(firstname, " ", lastname);

        }
    }
}
