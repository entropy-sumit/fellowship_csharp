using System;
using System.Collections.Generic;
using System.Text;

namespace day4Uc
{
    class uc8
    {
        public const int Isparttime = 1;
        public const int Isfulltime = 2;
    }

    public static int computeEmpwages(string company, int Emprateph, int numofwork, int Maxhrpmonth)
    {
        int emphr = 0, totalemphr = 0, totalworkingday = 0;

        while (totalemphr <= Maxhrpmonth && totalworkingday < numofwork)
        {
            totalworkingday++;
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
            Console.WriteLine("Day#;" + totalworkingday + "Emp hr :" + emphr);

        }
        int totalEmpwages = totalemphr * Emprateph;
        Console.WriteLine("total emp wages:" + totalEmpwages);
        return totalEmpwages;

    }
    public static void Main(string[] args)
    {
        computeEmpwages("TATA", 20, 10, 30);
        computeEmpwages("Isro", 30, 3, 20);


    }

    



}



