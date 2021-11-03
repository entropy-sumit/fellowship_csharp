using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Perfectnumber
    {
        public void per()
        {
            public static void Main(string[] args)
            {
                int number, add = 0, n;
                Console.Write("enter the Number");
                number = int.Parse(Console.ReadLine());
                n = number;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        add = add + i;
                    }
                }
                if (add == n)
                {
                    Console.WriteLine(" Entered number is a perfect number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(" Entered number is not a perfect number");
                    Console.ReadLine();
                }
            }
        

        }
        
    }
}
