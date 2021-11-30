using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class Uc4
    {

        public static string MobileNum = "[+][9][1][7-9]{2}[0-9]{8}";


        public bool validating(string name)
        {
            return Regex.IsMatch(name, MobileNum);
        }
    }
}
