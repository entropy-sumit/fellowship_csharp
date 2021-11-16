using System;

namespace AddressbookSystem
{
    class Program
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State  { get; set; }
        public string int Zipcode { get; set; }
        public string double Phonenumber { get; set; }
        public string Email { get; set; }

        public void displayContact()
        {
            Console.WriteLine("First Name:" + this.Firstname + "LastName:" + this.Lastname + "Address:" + this.Address + "City:" + this.City
                + "State:" + this.State + "Zipcode:" + this.Zipcode + "Phonenumber:" + this.Phonenumber + "Email:" + this.Email);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First name lastname Address city state zipcode phonenumber email");
            Program objprogram = new Program();
            {
                Firstname = Console.ReadLine();
                Lastname = Console.ReadLine();
                Address = Console.ReadLine();
                City = Console.ReadLine();
                State = Console.ReadLine();
                Zipcode = Convert.ToInt32( Console.ReadLine());
                Phonenumber = Convert.ToDouble(Console.ReadLine());
                Email = Console.ReadLine();

            };
            objprogram.displayContact();
            Console.ReadKey();
        }
    }
}
  