using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TravelPal.Classes
{
    public class IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }


    }
    

    public class User : IUser
    {

        public List<Travel> travels = new();

    }

    public class Admin : IUser
    {

    }

    


}
