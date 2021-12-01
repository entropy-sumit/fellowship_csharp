using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptioninRegistration
{
    public class InvalidExceptionHandling:Exception
    {
        public InvalidExceptionHandling(string Name) : base(string.Format("Invalid  Name{0}", Name))
            {

        }
    }
    
       
    
}
