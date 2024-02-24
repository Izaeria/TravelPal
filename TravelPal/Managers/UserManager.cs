﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        public static bool AddUser(IUser user)
        {
            Users.Add(user);
            return true;
        }

        public static bool ValidateUsername(string username)
        {
            foreach (var user in Users)
            {
                if(user.Username == username)
                {
                    MessageBox.Show("Sorry, that username is unavailable");
                    return false;
                }
            }
            if (username.Count() > 3) 
            {
                MessageBox.Show("Your username needs to be at least three characters!");
                return false;
            }
            return true;
        }

      

        public class Admin : IUser
        {

        }

    }
}



