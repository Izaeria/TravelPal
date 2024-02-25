﻿using System;
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

namespace TravelPal.Windows
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {

        private User users;

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
                cmbTravellers.Items.Add(i);

            }

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
                    int travellers = cmbTravellers.SelectedIndex;

                    Travel newTravel = new Travel(destination, selectedCountry, travellers);

                    User user = (User)UserManager.SignedInUser;
                    TravelManager.AddTravel(newTravel, user);
                    MessageBox.Show("Your travel has been saved!");

                    //Country countryNameString = cmbCountry.Text;
                    
                    //string destination = txtCity.Text;
                    //string travellers = cmbTravellers.Text;

                    //Travel newTravel = new(destination, country, travellers);

                    //User user = (User)UserManager.SignedInUser;
                    //TravelManager.AddTravel(newTravel, user);
                    //MessageBox.Show("Your travel has been saved!");
                }
            }
        }

        //TODO: Allinclusive box on vacation click
        //TODO: Meetingdetails on worktravel click

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelsWindow = new TravelsWindow();
            travelsWindow.Show();
            Close();

        }
    }
}
