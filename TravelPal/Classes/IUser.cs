using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TravelPal.Managers;

namespace TravelPal.Classes
{
    public class IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Country Country { get; set; }
    }
    

    public class User : IUser
    {

        public List<Travel> Travels = new();

    }

  


    public class Admin : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Country Country { get; set; }

      

    }




}
