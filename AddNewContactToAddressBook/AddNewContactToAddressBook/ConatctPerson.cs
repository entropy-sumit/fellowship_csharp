﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddNewContactToAddressBook
{
    class ConatctPerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string int Zipcode { get; set; }
        public string double Phonenumber { get; set; }
        public string Email { get; set; }

        public void displayContact()
        {
            Console.WriteLine("First Name:" + this.Firstname + "LastName:" + this.Lastname + "Address:" + this.Address + "City:" + this.City
                + "State:" + this.State + "Zipcode:" + this.Zipcode + "Phonenumber:" + this.Phonenumber + "Email:" + this.Email);
        }
        public void AddContact()
        {
            Console.WriteLine("Enter First name lastname Address city state zipcode phonenumber email");
            Program objprogram = new Program();
            ConatctPerson objContact = new ConatctPerson();
            {
                Firstname = Console.ReadLine();
                Lastname = Console.ReadLine();
                Address = Console.ReadLine();
                City = Console.ReadLine();
                State = Console.ReadLine();
                Zipcode = Convert.ToInt32(Console.ReadLine());
                Phonenumber = Convert.ToDouble(Console.ReadLine());
                Email = Console.ReadLine();

            }
            List<ConatctPerson> objList = new List<ConatctPerson>();
            objList.Add(objContact);
            objContact.displayContact();
            Console.ReadKey();
        }
    }
}
