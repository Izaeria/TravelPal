using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Managers;
using TravelPal.Classes;

namespace TravelPal.Classes
{
    public class Travel
    {
        public string? Destination { get; set; }
        public Country Country { get; set; }
        public int Travellers { get; set; }

       public Travel(string destination, Country country, int travellers)
        {
            Destination = destination;
            Country = country;
            Travellers = travellers;
        }
    

    }


    public void AddTravel(Travel travel)
    {
        Travels.Add(travel);
    }

    public void


        public void RemoveTravel(Travel travel)
    {
        Travels.Remove(travel)
    }



    public class WorkTrip : Travel
    {
        public string MeetingDetails { get; set; }

        //TODO meetingDetails
        //TODO GetInfo();
    }

    public class Vacation : Travel
    {
        public bool AllInclusive { get; set; }

        //TODO GetInfo();



    }

}