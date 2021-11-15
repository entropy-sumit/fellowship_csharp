using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagement
{
  public class InventoryModel
    {
        public List<Rice> Rice;
        public List<Pulses> Pulses;
        public List<Wheats> Wheats;
    }
    public class Rice
    {
        public string name;
        public string weight;
        public int price;
    }
    public class Wheats
    {
        public string name;
        public string weight;
        public int price;
    }
    public class Pulses
    {
        public string name;
        public string weight;
        public int price;
    }
}
