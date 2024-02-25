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

              
                MessageBox.Show("Your passwords do not match. Try again.");
            }
            else
            {
               string username = txtUsername.Text;
               string password = txtPassword.Password;

               bool registerSuccess = UserManager.RegisterUser(username, password);

                if (registerSuccess) {
                    MessageBox.Show("Welcome!");
                    MainWindow MainWindow = new();
                    MainWindow.Show();
                    Close();
                }
                
            }

         
        }
    }
}
        
    

