using System;
using System.Collections.Generic;
using System.Text;

namespace Employwage
{
    class uc4
    {
        int Ispartime = 1;
        int Isfulltime = 2;
        int Emp_rate_hr = 20;

    

    
        public static void Main(string[] args)
        {
            int emphr = 0;
            int empwages = 0;

            Random random = random.Next();

            int empcheck = random.Next(0, 3);

         switch (empcheck)
         {
            case Ispartime:
                emphr = 4;
                break;

            case Isfulltime:
                emphr = 8;
                break;

            default:
                emphr = 0;
                break;
         }
           empwages = emphr * Emp_rate_hr;
           Console.WriteLine("Emp wages :" + empwages);








        }


    }

}
