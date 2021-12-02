using System;
using System.Reflection;

namespace ReflectionOfRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //for assembly
            Assembly assembly = typeof(int).Assembly;
            Console.WriteLine(assembly);

            Type type = typeof(System.String);
            Console.WriteLine(type.Assembly);


            //For method
            Type t = typeof(UserRegistration);
            MethodInfo[] mi = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo m in mi)
            {
                Console.WriteLine(m);

            }
        }
    }
}
