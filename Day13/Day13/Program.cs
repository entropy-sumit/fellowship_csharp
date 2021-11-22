using System;

namespace Day13
{
    public class Program
    {
        static void Main(string[] args)
        {
            FindMaxIntuc1 intobj = new FindMaxIntuc1();
            Console.WriteLine("Int comparison");
            int a1 = 28;
            int a2 = 22;
            int a3 = 31;

            intobj.compairInteger(a1, a2, a3);
            Console.WriteLine("-------------------------");


            FindMaxFloatuc2 Floatobj = new FindMaxFloatuc2();
            Console.WriteLine("float comparison");
            float a1f = 2.80f;
            float a2f = 2.20f;
            float a3f = 3.10f;

            Floatobj.compairFloat(a1, a2, a3);
            Console.WriteLine("-------------------------");


            FindMaxStringUc3 stringObj = new FindMaxStringUc3();
            Console.WriteLine("string comparision");
            string name1 = "sumit";
            string name2 = "aakash";
            string name3 = "anuraghav";

            stringObj.compairString(name1, name2, name3);
            Console.WriteLine("------");




            int num4 = 40;
            int[] values = { num4 };
            Uc4.Max(values);




        }
    }
}
