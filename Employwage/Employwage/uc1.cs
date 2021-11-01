using System;

namespace Employwage
{ 
    public class uc1
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;

               
              Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck==isFullTime)
            {
                Console.WriteLine("employee is preseent");

            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
      

      


     
    }
}
