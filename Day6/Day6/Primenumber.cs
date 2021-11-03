using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Primenumber
    {
        public void prim()
        {
            public static void Main(string[] args)
            {
                int n, i, m = 0, flag = 0;
                Console.Write("Enter the Number to check Prime: ");
                n = int.Parse(Console.ReadLine());
                m = n / 2;
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write("Not Prime");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.Write("Prime");
            }
        }
        

    }
}

