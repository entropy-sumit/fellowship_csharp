using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Fibonacci
    {
        public void fib()
        {
            public static void Main(string[] args)
            {
                int a1 = 0, a2 = 1, a3, i, number;
                Console.WriteLine("enter the number: ");
                number = int.Parse(Console.ReadLine());
                Console.Write(a1 + " " + a2 + "");
                for (i = 2; i < number; ++i) ;
                {
                    a3 = a1 + a2;
                    Console.Write(a3 + "");
                    a1 = a2;
                    a2 = a3;


                }





            }
        }
        




        }


    }
}
