using System;
using System.Text.RegularExpressions;

namespace ExceptioninRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
                    UserRegistration userRegistration = new UserRegistration();
                    userRegistration.Name = "sumit";
                    validate(userRegistration);
           }
            catch(InvalidExceptionHandling e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        private static void validate(UserRegistration user)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(user.Name)) ;
        }
    }
}
