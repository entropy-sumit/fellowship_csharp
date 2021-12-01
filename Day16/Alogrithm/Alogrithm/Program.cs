using System;

namespace Alogrithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 21, 42, 63, 84 };
            int d;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        d = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = d;
                    }
                }
            }
            Console.WriteLine("Sorted array");
            foreach (int p in arr)
            {
                Console.WriteLine(p + " ");
            }
        }
    }
}
