using System;
using System.Collections.Generic;
using System.Text;

namespace Employwage
{
    class uc5
    {
        public const int Isparttime = 1;
        public const int Isfulltime = 2;
        public const int Emp_rate_per_hr = 20;
        public const int Number_of_working_days = 2;

    } 
    public static void Main(string[] args)
    {
        int emphr = 0, empwage = 0, totalwages = 0,;

        for (int day = 0; day < Number_of_working_days; day++)
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch(empcheck)
            {
                case Isparttime:
                    emphr = 4;
                    break;
                case Isfulltime:
                    emphr = 8;
                    break;
                default:
                    emphr = 0;
                    break;
            }
            empwage = emphr * Emp_rate_per_hr;
            totalwages += empwage;
            Console.WriteLine("Emp wage : " + empwage);
        }
        Console.WriteLine("Total wages :" + totalwages);


    }
}
