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
    public class TravelManager
    {

        public List<Travel> Travels { get; set; } = new()
        {
            new Vacation("Venice", Country.Italy),
            new WorkTrip("Toronto", Country.Canada)
        };



        public virtual string GetInfo()
        {

        }

        public void AddTravel(Travel travel)
        {
            Travels.Add(travel);
        }




        public void RemoveTravel(Travel travel)
        {
            Travels.Remove(travel);
        }




        public class WorkTrip : Travel
        {
            public string MeetingDetails { get; set; }

            public WorkTrip(string destination, Country country, int travellers : base(destination, country, travellers)
            {
                MeetingDetails = meetingDetails;
            }

            public WorkTrip(string v, Country canada)
            {
            }


            public override string GetInfo()
            {
                return base.GetInfo();
            }
        }

        public class Vacation : Travel
        {
            public bool AllInclusive { get; set; }

            public Vacation(string destination, Country country, IUser user)
            {
                AllInclusive = allInclusive;
            }

            public Vacation(string v, Country italy)
            {
            }

            public override string GetInfo()
            {
                return base.GetInfo();
            }





        }
    }
}
