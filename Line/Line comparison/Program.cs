using System;

namespace Line_comparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x1=2, x2=6, x3=4, x4=8, y1=2, y2=6, y3=4, y4=8;
            double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
             

            Console.WriteLine(line1);
            Console.WriteLine(line2);




            if (line1 > line2)
            {
                Console.WriteLine("line1 is greater");

            }

            else
            {
                Console.WriteLine("line2 is greater");
            }

        }
    }
}
