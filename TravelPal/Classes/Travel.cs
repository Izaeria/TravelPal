using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal.Classes
{
    public class Travel
    {
        public string Destination { get; set; }
        public List<string> Countries { get; set; }
        public int Travellers { get; set; }

        /*
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TravelDays { get; set; }
        */
    

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