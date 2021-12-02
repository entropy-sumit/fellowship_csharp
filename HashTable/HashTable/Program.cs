using Day_15_HashTable;
using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");
            Console.WriteLine();


            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "to");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            Console.WriteLine("Frequency of \'to\'  : " + hash.GetFrequencyOfWords("to"));
            Console.WriteLine("Frequency of \'be\' : " + hash.GetFrequencyOfWords("be"));
            Console.WriteLine("Frequency of \'or\' : " + hash.GetFrequencyOfWords("or"));
            Console.WriteLine("Frequency of \'not\' : " + hash.GetFrequencyOfWords("not"));
        }
    }
}
