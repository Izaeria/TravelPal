using System;
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
        }
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {

            if (txtPassword.Password != txtConfirmPassword.Password)
            {

                RegisterBtn.IsEnabled = false;
                MessageBox.Show("Your passwords do not match. Try again.");
            }
            else
            {
                User user = new();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Password;
                RegisterBtn.IsEnabled = true;
                MessageBox.Show("Welcome!");
                MainWindow MainWindow = new();
                MainWindow.Show();
                Close();
            }

            //TODO få metoden att fungera

            //if (UserManager.ValidateUsername(txtUsername.Text != user.Username))
            //{
            //    RegisterBtn.IsEnabled = true;
            //    MessageBox.Show("Welcome!");
            //    MainWindow MainWindow = new();
            //    MainWindow.Show();
            //    Close();
            //}

            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            //Close();
        }
    }
}
        
    

