using System;
using System.Collections.Generic;
using System.Text;

namespace Day13
{
    class Uc4
    {
        public static void Max(int[] values)
        {

            int max = values[0];

            for (int a = 1; a < values.Length; a++)
                if (values[a].CompareTo(max) > 0) max = values[a];

            Console.WriteLine("max number: " + max);
        }
    }
}
