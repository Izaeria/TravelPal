using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Diagnostics;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TravelPal.Classes;
using TravelPal.Managers;
using TravelPal.Windows;
using static TravelPal.Classes.Luggage;

namespace TravelPal.Windows
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {


        public AddTravelWindow()
        {
            InitializeComponent();
            LoadComboBoxes();
            UsernameLabel();
        }
        private void UsernameLabel()
        {
            lblUsername.Content = "Hello " + UserManager.SignedInUser.Username + "!";

        }

        private void LoadComboBoxes()
        {
            foreach (Country country in Enum.GetValues(typeof(Country)))
            {
                cmbCountry.Items.Add(country);
            }
            
            for (int i = 1; i < 11; i++)
            {
                cmbTravelers.Items.Add(i);
            }
            cmbType.Items.Add("Vacation");
            cmbType.Items.Add("Worktrip");


        }

        private void saveDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCountry.Text) || string.IsNullOrEmpty(txtCity.Text) || cmbTravelers.SelectedItem == null || cmbType.SelectedItem == null)
            {
                MessageBox.Show("Please ensure all fields are completed.");
            }
           
            else
            {
                if (cmbType.SelectedIndex == 0)
                {
                    Country selectedCountry;
                    if (Enum.TryParse(cmbCountry.Text, out selectedCountry))
                    {
                        string destination = txtCity.Text;
                        int travelers = cmbTravelers.SelectedIndex + 1;
                        bool isAllInclusive = false;
                        if (xbAllInclusive.IsChecked == true)
                        {
                            isAllInclusive = true;
                        }

                        Vacation newVacation = new Vacation(destination, selectedCountry, travelers, isAllInclusive);

                        User user = (User)UserManager.SignedInUser;
                        TravelManager.AddTravel(newVacation, user);
                        MessageBox.Show("Your travel has been saved!");

                    }
                }
                else
                {
                    Country selectedCountry;
                    if (Enum.TryParse(cmbCountry.Text, out selectedCountry))
                    {
                        string destination = txtCity.Text;
                        int travelers = cmbTravelers.SelectedIndex + 1;
                        string meetingDetails = txtMeetingDetails.Text;

                        WorkTrip newWorktrip = new WorkTrip(destination, selectedCountry, travelers, meetingDetails);

                        User user = (User)UserManager.SignedInUser;
                        TravelManager.AddTravel(newWorktrip, user);
                        MessageBox.Show("Your travel has been saved!");

                    }
                }
            }

            }

        private void CmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbType.SelectedItem != null && cmbType.SelectedItem.ToString() == "Vacation")
            {
                xbAllInclusive.Visibility = Visibility.Visible;
            }
            else
            {
                xbAllInclusive.Visibility = Visibility.Hidden;
            }
            if (cmbType.SelectedItem != null && cmbType.SelectedItem.ToString() == "Worktrip")
            {
                txtbMeetingDetails.Visibility = Visibility.Visible; 
                txtMeetingDetails.Visibility = Visibility.Visible;
            }
            else
            {
                txtMeetingDetails.Visibility= Visibility.Hidden;
            }
        }


        private void addLuggageBtn_Click(object sender, RoutedEventArgs e)
        {
            
                if (xbTravelDocument.IsChecked == true)
                {

                    string name = txtAddLuggage.Text;
                    bool isRequired;
                    string required;
                    if (xbRequired.IsChecked == true)
                    {
                        isRequired = true;
                    }
                    else
                    {
                        isRequired = false;
                    }

                    AddTravelDocument(name, isRequired);

                    ClearLuggageFields();
                }
                else 
                {
                        string name = txtAddLuggage.Text;
                  

                         Items items = new(name);

                        ListViewItem listViewItem = new();
                        listViewItem.Tag = items;
                        listViewItem.Content = items.GetInfo();
                        lstLuggage.Items.Add(listViewItem);

                        ClearLuggageFields();

                    }
                
        }
        private void AddTravelDocument(string name, bool isRequired)
        {
            TravelDocument travelDocument = new(name, isRequired);

            ListViewItem listViewItem = new();
            listViewItem.Tag = travelDocument;
            listViewItem.Content = travelDocument.GetInfo();

            lstLuggage.Items.Add(listViewItem);
        }
        private void ClearLuggageFields()
        {
            txtAddLuggage.Clear();
            xbRequired.IsChecked = false;
            xbTravelDocument.IsChecked = false;
        }


        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelsWindow = new TravelsWindow();
            travelsWindow.Show();
            Close();
        }


        private void txtTravelDocument_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
