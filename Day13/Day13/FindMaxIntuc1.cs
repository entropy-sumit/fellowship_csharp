using System;
using System.Collections.Generic;
using System.Text;

namespace Day13
{
    public class FindMaxIntuc1
    
    {
        public void compairInteger(int a1, int a2, int a3)
            {
                if (a1.CompareTo(a2) > 0 && a1.CompareTo(a3) > 0 || a1.CompareTo(a2) >= 0 && a1.CompareTo(a3) > 0 || a1.CompareTo(a2) > 0 && a1.CompareTo(a3) >= 0)
                {
                    Console.WriteLine("the number 1 larger than number 2 and 3");
                }
                else if (a2.CompareTo(a1) > 0 && a2.CompareTo(a3) > 0 || a2.CompareTo(a1) >= 0 && a2.CompareTo(a3) > 0 || a2.CompareTo(a1) > 0 && a2.CompareTo(a3) >= 0)
                {
                    Console.WriteLine("the number 2 larger than number 1 and 3");
                }
                else if (a3.CompareTo(a2) > 0 && a3.CompareTo(a1) > 0 || a3.CompareTo(a2) > 0 && a3.CompareTo(a1) >= 0 || a3.CompareTo(a2) >= 0 && a3.CompareTo(a1) > 0)
                {
                    Console.WriteLine("the number 3 larger than number 1 and 2");
                }
            }
        }
    
}

