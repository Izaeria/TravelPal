using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal.Classes
{
    internal class Luggage
    {
        public string Name { get; set; }
        public bool Required { get; set; }


        public class TravelDocument : Luggage
        {
            public string Name { get; set; }
            public bool Required { get; set; }

            public TravelDocument(string name, bool required)
            {
                Name = name;
                Required = required;
            }


            public string GetInfo()
            {
                return Name + ", required: " + Required;
            }
        }

        public class Items : Luggage
        {
            public string Name { get; set; }
            public int Quantity { get; set; }

            public Items(string name, int quantity)
            {
                Name = name; 
                Quantity = quantity;
            }

            public string GetInfo()
            {
                return Name;
            }
        }
    }
}