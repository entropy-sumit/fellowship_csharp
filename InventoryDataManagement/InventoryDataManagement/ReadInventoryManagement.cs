using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace InventoryDataManagement
{
    public class ReadInventoryManagement
    {
       public InventoryModel Read(string path)
        {
            using(StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    return JsonConverter.DeserializeObject<InventoryModel>(json);

                }
                catch(Exception e)
                {
                    Console.WriteLine("Problem is getting data{0}", e);
                    return null;
                }
            }
        }
    }
}
