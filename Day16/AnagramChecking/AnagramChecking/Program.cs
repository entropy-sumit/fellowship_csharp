using System;

namespace AnagramChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "dusty";

            string str2 = "study";

            char[] char1 = str1.ToLower().ToCharArray();

            char[] char2 = str2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            String val1 = new string(char1);

            String val2 = new string(char2);

            if (val1 == val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not an anagram");
            }
        }
    }
}
