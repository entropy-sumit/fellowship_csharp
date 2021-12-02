using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReflectionOfRegistration
{
     class UserRegistration
    {
        public static string First_nameuc1 = "^[A-Z]{3}";



        public bool validating(string name)
        {
            return Regex.IsMatch(name, First_nameuc1);
        }

    }
    
}
