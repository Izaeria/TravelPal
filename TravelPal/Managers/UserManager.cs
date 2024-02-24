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
        public static List<IUser> Users { get; set; } = new()
        {
            new Admin {Username = "admin", Password = "password"},
            new User {Username = "username", Password = "password"}
        };


        public static IUser SignedInUser { get; set; }

        internal static bool SignInUser(string username, string password)
        {
            foreach (var user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    SignedInUser = user;
                    return true;
                }
            }
            return false;
        }

        public class Admin : IUser
        {

        }

    }
}



