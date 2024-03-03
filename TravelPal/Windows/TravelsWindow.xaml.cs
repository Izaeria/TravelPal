using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        private IUser user;

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
          if (UserManager.SignedInUser is Admin)
                {
                    addTravelBtn.IsEnabled = false;
                }
            else { 
            AddTravelWindow addTravelWindow = new AddTravelWindow();
            addTravelWindow.Show();
            Close();
            }
        }

        
        private void checkDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (lstTravels.SelectedItem != null)
            {

                ListViewItem selectedItem = new ListViewItem();
                selectedItem = (ListViewItem)lstTravels.SelectedItem;
                Travel selectedTravel = (Travel)selectedItem.Tag;

                TravelDetailsWindow travelDetailsWindow = new TravelDetailsWindow(selectedTravel, user);
                travelDetailsWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("You must select an existing travel");
            }
        }



        private void removeTravelsBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (lstTravels != null)
            {
                if (lstTravels.SelectedItem != null)
                {
                    ListViewItem selectedItem = (ListViewItem)lstTravels.SelectedItem;
                    Travel selectedTravel = (Travel)selectedItem.Tag;

                    if (UserManager.SignedInUser is User)
                    {
                       
                        User user = UserManager.SignedInUser as User;
                        user.Travels.Remove(selectedTravel);
                    }
                    else if (UserManager.SignedInUser is Admin)
                    {
                       foreach (User user in UserManager.Users)
                        {
                            if (user is User)
                            {
                                User usernew = (User)user;

                                if (user.Travels.Contains(selectedTravel))
                                {
                                   
                                    user.Travels.Remove(selectedTravel);
                                    break;
                                }
                            }
                        }
                    }

                    lstTravels.Items.Remove(selectedItem);
                }
                else
                {
                    MessageBox.Show("You must select a travel before clicking remove!");
                }

            }

        }


        private void signOutBtn_Click(object sender, RoutedEventArgs e)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }

            //TODO Write about how the app works
            private void aboutBtn_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("TravelPal is an app used for adding, removing and viewing trips!");
            }
        
    }
}
