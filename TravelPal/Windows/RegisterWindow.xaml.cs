﻿using System;
using System.Collections.Generic;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window

    {
        public RegisterWindow()
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

        }
            private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {

            if (txtPassword.Password != txtConfirmPassword.Password)
            {
                MessageBox.Show("Your passwords do not match. Try again.");
            }
            if (UserManager.Users.Any(user => user.Username == txtUsername.Text))
            {
                MessageBox.Show("That username is already taken. Please choose another one.");
            }
            if (cmbCountry.SelectedItem == null)
            {
                MessageBox.Show("Please choose a country of origin!");
            }
            else
            {
               string username = txtUsername.Text;
               string password = txtPassword.Password;
               Country country = (Country)cmbCountry.SelectedItem;

               bool registerSuccess = UserManager.RegisterUser(username, password, country);

                if (registerSuccess) {
                    MessageBox.Show("Welcome!");
                    MainWindow MainWindow = new();
                    MainWindow.Show();
                    Close();
                }
                
            }


         
        }
        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
        
    

