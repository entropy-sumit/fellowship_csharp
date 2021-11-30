using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_programs
{
    public class Headandtail
    {
        public static void Perheadtail()
        {
            int head = 0;
            int tail = 0;
            int Coinresult = 0;

            Random random = new Random();
            Console.WriteLine("enter the value");
            int readinput = int.Parse(Console.ReadLine());
            for(int i=0; i<readinput; i++)
            {
                Coinresult = random.Next(0, 2);
                if(Coinresult==0)
                {
                    tail++;
                }

                else
                {
                    head++;
                }



            }
            int resulthead = (head * 100 / readinput);
            int resulttail = (tail * 100 / readinput);
            Console.WriteLine("Head percentage" + resulthead);
            Console.WriteLine("Tail percentage" + resulttail);

        }
    }
}
