using System;

namespace InsertionSortAlgo
{
    class Program
    {
        static void insert(int[] a)
        {
            int i, j, temp;
            int n = a.Length;
            for (i = 1; i < n; i++)
            {
                temp = a[i];
                j = i - 1;

                while (j >= 0 && temp <= a[j])
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = temp;
            }
            static void printArr(int[] a)
            {
                int i;
                int n = a.Length;
                for (i = 0; i < n; i++)
                    Console.Write(a[i] + " ");
            }
            static void main()
            {
                int[] a = { 98, 54, 53, 18, 21, 12 };
                Console.Write("Before sorting array elements are - \n");
                printArr(a);
                insert(a);
                Console.Write("\nAfter sorting array elements are - \n");
                printArr(a);
            }

        }

    }
}
