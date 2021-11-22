using System;
using System.Collections.Generic;
using System.Text;

namespace Day13
{
    public class FindMaxFloatuc2
    {
        public void compairFloat(float a1f, float a2f, float a3f)
        {
            if (a1f.CompareTo(a2f) > 0 && a1f.CompareTo(a3f) > 0 || a1f.CompareTo(a2f) >= 0 && a1f.CompareTo(a3f) > 0 || a1.CompareTo(a2) > 0 && a1.CompareTo(a3) >= 0)
            {
                Console.WriteLine("the number 1 larger than number 2 and 3");
            }
            else if (a2f.CompareTo(a1f) > 0 && a2f.CompareTo(a3f) > 0 || a2f.CompareTo(a1f) >= 0 && a2f.CompareTo(a3f) > 0 || a2f.CompareTo(a1f) > 0 && a2f.CompareTo(a3f) >= 0)
            {
                Console.WriteLine("the number 2 larger than number 1 and 3");
            }
            else if (a3f.CompareTo(a2f) > 0 && a3f.CompareTo(a1f) > 0 || a3f.CompareTo(a2f) > 0 && a3f.CompareTo(a1f) >= 0 || a3f.CompareTo(a2f) >= 0 && a3f.CompareTo(a1f) > 0)
            {
                Console.WriteLine("the number 3 larger than number 1 and 2");
            }
        }
    }
}
