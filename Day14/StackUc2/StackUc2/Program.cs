using System;
using System.Collections.Generic;
using System.Text;

namespace StackUc2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Stack<int> stack = new Stack<int>();
                stack.Push(70);
                stack.Push(30);
                stack.Push(56);

                foreach (int item in stack)
                {
                    Console.WriteLine("Pushing the Elements in Stack");
                    Console.WriteLine(item);
                }
                Console.WriteLine("--------------------------------\n");

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Peek the Integer : " + stack.Peek());
                    Console.WriteLine("Poping the Elements out of Stack : " + stack.Pop());
                }

                Console.WriteLine("---------------------------------\n");
            }
        }
    }
}
