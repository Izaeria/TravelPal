using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TravelPal.Classes;
using TravelPal.Managers;
using TravelPal.Windows;



namespace TravelPal.Windows
{
    /// <summary>
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {
        public TravelsWindow()
        {
            InitializeComponent();
            UsernameLabel();
            DisplayTravels();

        }

        private void UsernameLabel()
        {
            lblUsername.Content = "Hello " + UserManager.SignedInUser.Username + "!";
        }

        private void DisplayTravels()
        {
            if (UserManager.SignedInUser.GetType() == typeof(User))
            {
                //

                User user = (User)UserManager.SignedInUser;

                foreach (Travel travel in user.Travels)
                {
                    ListViewItem item = new();
                    item.Tag = travel;
                    item.Content = travel.GetInfo();
                    lstTravels.Items.Add(item);
                }
            }
            else
            {
                foreach (IUser user in UserManager.Users)
                {
                    if (user.GetType() == typeof(User))
                    {
                        User user1 = (User)user;
                        foreach (Travel travel in user1.Travels)
                        {
                            ListViewItem item = new();
                            item.Tag = travel;
                            item.Content = travel.GetInfo();
                            lstTravels.Items.Add(item);
                        }

                    }
                }
            }


        }



        private void addTravelBtn_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindow = new AddTravelWindow();
            addTravelWindow.Show();
            Close();
        }

        //TODO: Actually show details
        private void checkDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            TravelDetailsWindow travelDetailsWindow = new TravelDetailsWindow();
            travelDetailsWindow.Show();
            Close();
        }
        private void removeTravelsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (lstTravels.SelectedItem != null)
            {
                if (UserManager.SignedInUser is User)
                {

                    Travel selectedTravel = (Travel)((ListBoxItem)lstTravels.SelectedItem).Tag;
                    lstTravels.Items.Remove(lstTravels.SelectedItem);

                    User thisUser = (User)UserManager.SignedInUser;
                    thisUser.Travels.Remove(selectedTravel);


                }
                else
                {
                    foreach (IUser users in UserManager.Users)
                    {

                        if (UserManager.SignedInUser is Admin)
                        {
                            User currentUser = (User)users;
                            Travel selectedTravel = (Travel)lstTravels.SelectedItem;

                            if (currentUser.Travels.Contains(selectedTravel))
                            {
                                // Remove the travel from the user's travels list
                                currentUser.Travels.Remove(selectedTravel);
                            }
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("You must select an existing travel");
            }


        }

            //TODO: Actually remove a travel
            //private void removetravelsBtn_Click(object sender, RoutedEventArgs e)
            //{

            //    if (selectedTravel == null)
            //    {

            //    }

            //    else
            //            {
            //                MessageBox.Show("Your travel location has been removed!");
            //            }

            //}

            //private Travel selectedTravel;


            //// Metod för att kunna välja en travel
            //public Travel SelectedTravel
            //{
            //    get { return selectedTravel; }
            //    set
            //    {
            //        selectedTravel = value;
            //        OnPropertyChanged(nameof(SelectedTravel)); 
            //    }
            //}


            //public event PropertyChangedEventHandler PropertyChanged;

            //protected void OnPropertyChanged(string propertyName)
            //{
            //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //}


            private void signOutBtn_Click(object sender, RoutedEventArgs e)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }

            //TODO Write about how the app works
            private void aboutBtn_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("A small little company for easy travels");
            }
        
    }
}
