using System;
using System.Collections.Generic;
using System.Text;

namespace Employwage
{
    class uc6
    {
        public const int Isparttime = 1;
        public const int Isfulltime = 2;
        public const int Emp_rate_Hr = 20;
        public const int Numberofworkingdays = 2;
        public const int Max_hr_in_month = 10;

    }
     public static void Main(string[] args)
    {
        int emphr = 0, totalworkingdays= 0, totalemphr = 0,;

        while(totalemphr <= Max_hr_in_month && totalworkingdays < Numberofworkingdays)
        {
            totalworkingdays++;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
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
            totalemphr += emphr;
            Console.WriteLine("Days#:" + totalworkingdays + "Emp hr:" + emphr);
        }
        int totalwages = totalemphr * Emp_Rate_Hr;
        Console.WriteLine("Total wages :" + totalwages);
    }
