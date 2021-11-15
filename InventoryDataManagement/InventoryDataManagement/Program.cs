using System;

namespace InventoryDataManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "D:/Inventory.json";
            Console.WriteLine("Welcome to the inventory management");

            ReadInventoryManagement readInventoryManagement = new ReadInventoryManagement();
            InventoryModel data = readInventoryManagement.Read(path);

            Console.WriteLine("Rice details");
            for (int i = 0; i < data.Rice.Count; i++)
            {
                //int valueofRice = data.Rice[i].weight * data.Rice[i].price;

                Console.WriteLine("Name:" + data.Rice[i].name + "Weight:" + data.Rice[i].weight + "Price:"+data.Rice[i].price);
                //Console.WriteLine("The value of {0} is {1}", data.Rice[i].name, valueofRice);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("Pulses details");
            for (int i = 0; i < data.Pulses.Count; i++)
            {

                //int valueofPulses = data.Pulses[i].weight * data.Pulses[i].price;

                Console.WriteLine("Name:" + data.Pulses[i].name + "Weight:" + data.Pulses[i].weight + "Price:" + data.Pulses[i].price);
                //Console.WriteLine("The value of {0} is {1}", data.Pulses[i].name, valueofPulses);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("Wheat details");
            for (int i = 0; i < data.Wheats.Count; i++)
            {

                //int valueofWheat = data.Wheats[i].weight * data.Wheats[i].price;
                 
                Console.WriteLine("Name:" + data.Wheats[i].name + "Weight:" + data.Wheats[i].weight + "Price:" + data.Wheats[i].price);
                //Console.WriteLine("The value of {0} is {1}", data.Wheats[i].name, valueofWheat);
                Console.WriteLine("--------------------------");
            }
        }
    }

}

