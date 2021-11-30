using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class Uc2
    {

        public static string Last_nameuc2 = "[A-Z]{3}$";


        public bool validating(string name)
        {
            return Regex.IsMatch(name, Last_nameuc2);
        }
    }
}

