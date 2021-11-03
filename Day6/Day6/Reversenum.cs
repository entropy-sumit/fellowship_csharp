using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Reversenum
    {
        public void rev()
        {
            public static void Main(string[] args)
            {
                int n, reverse = 0, rem;
                Console.Write("input number: ");
                n = int.Parse(Console.ReadLine());
                while (n != 0)
                {
                    rem = n % 10;
                    reverse = reverse * 10 + rem;
                    n /= 10;
                }
                Console.Write("Reversed Number: " + reverse);
            }
        }
        
    }
}
