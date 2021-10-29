using System;

namespace Demo2
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Calculator objCalculator = new Calculator();
            Console.WriteLine("totalSum="+objCalculator.isSum(20, 20));
            Console.WriteLine("totalSub="+objCalculator.isSum(20, 20));
            Console.WriteLine("totalMul="+objCalculator.isSum(20, 20));
            Console.WriteLine("totalDiv="+objCalculator.isSum(20, 20));
            Console.ReadKey();

        }
    
    }


}
