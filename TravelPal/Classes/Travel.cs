using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Managers;
using TravelPal.Classes;
using System.Xaml;
using System.Xml.Linq;

namespace TravelPal.Classes
{
    public class Travel
    {
        public string? Destination { get; set; }
        public Country Country { get; set; }
        public int Travelers { get; set; }

       public Travel(string destination, Country country, int travelers)
        {
            Destination = destination;
            Country = country;
            Travelers = travelers;
        }
        public virtual string GetInfo()
        {
            string info = $"{Destination} - {Country}";
            return info;
        }


    }

  

}
