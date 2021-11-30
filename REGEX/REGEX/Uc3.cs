using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class Uc3
    {

        public static string Email_uc3 = "^[a-z]{*}[.][a-z]{*}[@][bl][.][co].[in]$";

        public bool validating(string name)
        {
            return Regex.IsMatch(name, Email_uc3);
        }
    }
}
