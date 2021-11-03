using System;

namespace Day6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        Label: Console.WriteLine("1.fibonacci series is \n 2.perfectnumber \n 3.primenumber \n 4.reverse number \n 5.coupon \n 6.stopwatch");
            
            Console.WriteLine("type the option");
            int i = int.Parse(Console.ReadLine());


            switch (i)
            {
                case 1:
                    Console.WriteLine("1.fibonacci series is");
                    Fibonacci fibnaci = new Fibonacci();
                    fibnaci.fib();
                    break;
                case 2:
                    Console.WriteLine("2.perfectnumber");
                    Perfectnumber.perfect= new Perfectnumber();
                    perfect.per();
                    break;
                case 3:
                    Console.WriteLine("3.primenumber");
                    Primenumber.prime = new Primenumber();
                    prime.prim();
                    break;
                case 4:
                    Console.WriteLine("4.reverse number");
                    Reversenum.reversenum = new Reversenum;
                    Reversenum.rev();
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;

            }
            Console.WriteLine("do you wnat continue...yes/no");
            if (Console.ReadKey().KeyChar.ToString() == "yes")
            {
                goto Label;

            }
            Console.ReadKey();
        }
    }
}
