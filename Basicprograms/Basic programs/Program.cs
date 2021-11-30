using System;

namespace Basic_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Choice : \n1.Headandtail. \n2.Leapyear. \n3.Harmonic Number. \n4.Power of 2. \n5.Swap. \n6.EvenOdd.");

            int key = Convert.ToInt32(Console.ReadLine());

            switch (key)
            {
                case 1:
                    Headandtail.Perheadtail();
                    break;
                case 2:
                    Leapyear.Leap();
                    break;
                case 3:
                    Harmonic.harmonicno();
                    break;
                case 4:
                    PowerOfTwo.poweroftwo();
                    break;
                case 5:
                    Swap.swap();
                    break;
                case 6:
                    OddEven.OddEven();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;




            }
        }
    }
}
