using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Classes;

namespace TravelPal.Managers
{
    internal class UserManager
    {
        public class User : IUser
        {

            public List<Travel> travels = new();

        }

        public class Admin : IUser
        {

        }
    }
}
