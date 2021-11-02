using System;
using System.Collections.Generic;
using System.Text;

namespace day4Uc
{
    public class uc9
    {
        public static void Main(string[] args)
        {
            Empbuilder tata = new Empbuilder("tata", 10, 2, 20);
            Empbuilder app = new Empbuilder("app", 21, 3, 30);
            tata.computeEmpwages();
            Console.WriteLine(tata.ToString());
            app.computeEmpwages();
            Console.WriteLine(app.ToString());

        }
        public class Empbuilder
        {
            public const int Isparttime = 1;
            public const int Isfulltime = 2;


            public string company;
            public int Empratehr;
            public int Numberofworkday;
            public int Maxhrinmonth;
            public int totalwages;
            public Empbuilder(string company, int Empratehr, int Numberofworkday,
        int Maxhrinmonth)
            {
                this.company = company;
                this.Empratehr = Empratehr;
                this.Numberofworkday = Numberofworkday;
                this.Maxhrinmonth = Maxhrinmonth;
            }

            public void computeEmpwages()
            {

                int emphr = 0, totalemphr = 0, totalworkingday = 0;
                while (totalemphr <= this.Maxhrinmonth && totalworkingday < this.Numberofworkday)
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
                    Console.WriteLine("Day#;" + totalworkingday + "Emp hr :" + emphr)



                }
             totalEmpwages = totalemphr * this.Empratehr;
             Console.WriteLine("total emp wages:" + company + "is:" + totalEmpwages);

            public string tostring()
             {

                    return "total emp wages:" + company + "is:" + totalEmpwages
             }


            }
        }
    }
}


        