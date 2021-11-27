using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class Checking
    {
        //public static string First_nameuc1 = "^[A-Z]{3}";
        //public static string Last_nameuc2 = "[A-Z]{3}$";
        //public static string Email_uc3 = "^[a-z]{*}[.][a-z]{*}[@][bl][.][co].[in]$";
        public static string MobileNum = "[+][9][1][7-9]{2}[0-9]{8}";


        public bool validating(string name)
        {
            return Regex.IsMatch(name, MobileNum);
        }
    }
}
