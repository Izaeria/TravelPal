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
            if (string.IsNullOrEmpty(cmbCountry.Text) || string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Please ensure all fields are completed.");
            }
            else
            {
                Country selectedCountry;
                if (Enum.TryParse(cmbCountry.Text, out selectedCountry))
                {
                    string destination = txtCity.Text;
                    int travelers = cmbTravelers.SelectedIndex;

                    Travel newTravel = new Travel(destination, selectedCountry, travelers);

                    User user = (User)UserManager.SignedInUser;
                    TravelManager.AddTravel(newTravel, user);
                    MessageBox.Show("Your travel has been saved!");

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

        //TODO Add packing list inputs
        private void addLuggageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAddLuggage.Text))
            {
                if (xbTravelDocument.IsChecked == true)
                {
                    //Lägg till ett travel document

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
                    int quantity = int.Parse(cmbQuantity.SelectedItem.ToString());

                         Items items = new(name, quantity);

                        ListViewItem listViewItem = new();
                        listViewItem.Tag = items;
                        listViewItem.Content = items.GetInfo();
                        lstLuggage.Items.Add(listViewItem);

                        ClearLuggageFields();



                    }
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

        private void addItemBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your item(s) has been added!");
        }

        private void txtTravelDocument_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
