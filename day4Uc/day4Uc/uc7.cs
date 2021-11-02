using System;

namespace day4Uc
{
    class uc7
    {
        public const int Isparttime = 1;
        public const int Isfulltime = 2;
        public const int Emp_rate_hr = 20;
        public const int Num_of_working_days = 2;
        public const int Max_hr_in_month = 10;
        public static int computeEmpwages()
        {
            int emphr = 0, totalemphr = 0, totalworkingday = 0;

            while (totalemphr <= Max_hr_in_month && totalworkingday < Num_of_working_days)
            {
                totalworkingday++;
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
                totalemphr += emphr;
                Console.WriteLine("Day#;" + totalworkingday + "Emp hr :" + emphr);


            }
             int totalEmpwages = totalemphr * Emp_rate_hr;
            Console.WriteLine("total emp wages:" + totalEmpwages);
            return totalEmpwages;

       }

        public static void Main(string[] args)
        {
            computeEmpwages();

        }
    }

}
