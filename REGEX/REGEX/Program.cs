using System;

namespace REGEX
{
    class Program
    {
        static void Main(string[] args)
        {

            bool CheckValue;
            //string check = "UNO";

            //string check = "bride UNO";

            //string check = "abc.xyz@bl.co.in";

            string check = "+918912345678";

           

            Uc1 checking = new Uc1();
            CheckValue = checking.validating(check);

            if (CheckValue)
            {
                Console.WriteLine("pattern matched");

            }
            else
            {
                Console.WriteLine("not matched");
            }
        }
    }
}
