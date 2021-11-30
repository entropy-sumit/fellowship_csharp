using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic_programs
{
    class PowerOfTwo
    {
        public static void poweroftwo()
        {
            Console.WriteLine("Enter the Power of 2 :: ");
            int n = int.Parse(Console.ReadLine());
            int i;
            int power = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    power = 1;
                }
                else
                {
                    power = power * 2;
                }

            }
            Console.WriteLine(power);
            Console.ReadLine();

        }
     
        
    }
    
}