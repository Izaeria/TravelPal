using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;
using TravelPal.Classes;
using TravelPal.Managers;
using TravelPal.Windows;


namespace TravelPal.Managers
{
    public static class TravelManager
    {

        public static List<Travel> Travels { get; set; } = new()
        {
            new Vacation("Venice", Country.Italy, 2, true),
            new WorkTrip("Toronto", Country.Canada, 4, "Business")
        };





        public static void AddTravel(Travel travel)
        {
            Travels.Add(travel);
        }




        public static void RemoveTravel(Travel travel)
        {
            Travels.Remove(travel);
        }




        



          
       
    }
}
