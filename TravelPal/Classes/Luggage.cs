﻿using System;
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
                return "Passport" + ", required: " + Required;
            }
        }

        public class Items : Luggage
        {
            public string Name { get; set; }

            public Items(string name)
            { Name = Name; }

            public string GetInfo()
            {
                return Name;
            }
        }
    }
}