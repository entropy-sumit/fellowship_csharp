using System;

namespace Demo2
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Calculator objCalculator = new Calculator();
            Console.WriteLine("totalvalue="+ objCalculator.isSum(20, 20));
            Console.ReadKey();

        }
    
    }


}
