using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Managers;

namespace TravelPal.Classes
{
  
        public class WorkTrip : Travel
        {
            public string MeetingDetails { get; set; }

            public WorkTrip(string destination, Country country, int travelers, string meetingDetails) : base(destination, country, travelers)
            {
                MeetingDetails = meetingDetails;
            }

            public override string GetInfo()
        {
            return base.GetInfo();
        }


    }
}