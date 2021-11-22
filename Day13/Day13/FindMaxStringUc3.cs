using System;
using System.Collections.Generic;
using System.Text;

namespace Day13
{
    class FindMaxStringUc3
    {
        public void compairString(string name1, string name2, string name3)
        {
            if (name1.CompareTo(name2) > 0 && name1.CompareTo(name3) > 0 || name1.CompareTo(name2) >= 0 && name1.CompareTo(name3) > 0 || name1.CompareTo(name2) > 0 && name1.CompareTo(name3) >= 0)
            {
                Console.WriteLine("the name 1 larger than name 2 and 3");
            }
            else if (name2.CompareTo(name1) > 0 && name2.CompareTo(name3) > 0 || name2.CompareTo(name1) >= 0 && name2.CompareTo(name3) > 0 || name2.CompareTo(name1) > 0 && name2.CompareTo(name3) >= 0)
            {
                Console.WriteLine("the name 2 larger than name 1 and 3");
            }
            else if (name3.CompareTo(name2) > 0 && name3.CompareTo(name1) > 0 || name3.CompareTo(name2) > 0 && name3.CompareTo(name1) >= 0 || name3.CompareTo(name2) >= 0 && name3.CompareTo(name1) > 0)
            {
                Console.WriteLine("the name 3 larger than name 1 and 2");
            }
        }
}
