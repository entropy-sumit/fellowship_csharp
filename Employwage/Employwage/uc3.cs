using System;
using System.Collections.Generic;
using System.Text;

namespace Employwage
{
   public class uc3
   {
        public static void Main(string[] args)
        {
            int Ispartime = 1;
            int Isfulltime = 2;
            int Emp_rate_hr = 20;

            int emphr = 0;
            int empwages = 0;

            Random random = random.Next();

            int empcheck = random.Next(0, 3);
            if (empcheck == Ispartime)
            {
                emphr = 4;

            }
            else if (empcheck == Isfulltime )
            {
                emphr = 8;

            }

            else
            {

                emphr = 0;
            }

            empwages = emphr * Emp_rate_hr;
            Console.WriteLine("Emp wages :" + empwages)



        }
        
        
        








    }
}
