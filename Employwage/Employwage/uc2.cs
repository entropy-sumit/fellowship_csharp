using System;
using System.Collections.Generic;
using System.Text;

namespace Employwage
{
    public class uc2
    {

        public static void Main(string[] args)

        int IsFulltime = 1;
        int Emp_rate_per_hours = 20;
        int emphr = 0;
        int empwages = 0;

        Random random = new Random();

        int empCheck = random.Next(0, 2);
          
        if (empCheck == IsFulltime)
            {
               emphr =8;
            
            }
         
            
               
            
      
         else
         {
            emphr = 0;
         }

           empwages = emphr* Emp_rate_per_hours;
           Console.WriteLine("Emp wages : " + empwages);


     }



}

      