using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_programs
{
    class Swap
    {
        public static void swap()
        {
            int a, b, temp;

            Console.WriteLine("\nInput the First Number : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInput the Second Number : ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            a = temp;
            
            Console.WriteLine("\nFirst Number : " + a);

            Console.WriteLine("\nSecond Number : " + b);
            Console.ReadLine();
        }
    }
}
