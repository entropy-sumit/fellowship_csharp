using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_programs
{
    class Harmonic
    {
        public static void harmonicno()
        {
            float i;
            double a = 0;
            Console.WriteLine("Enter the number : ");
            float n = int.Parse(Console.ReadLine());


            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                a += 1 / (float)i;
            }

            Console.WriteLine(" \n Harmonic Number. " + a);
            Console.ReadLine();
        }
    }
}
