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
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    /// 


  
    public partial class TravelDetailsWindow : Window
    {  
        
        private Travel travel;
       
        private IUser user;

        
        public TravelDetailsWindow(Travel travel, IUser user)
        {
            this.user = user;
            this.travel = travel;
            InitializeComponent();
            LoadAllTravelInfo();

        }
      
        public void LoadAllTravelInfo()
        {
            
            {
                if (travel.GetType() == typeof(Vacation))
                {
                    Vacation vacation = (Vacation)travel;
                    txtDestination.Text = vacation.Destination;
                    txtCountry.Text = vacation.Country.ToString();
                    txtTravelers.Text = vacation.Travelers.ToString(); 

                    if (vacation.AllInclusive)
                    {
                        txtbAllInclusive.Visibility = Visibility.Visible;
                        txtAllInclusive.Visibility = Visibility.Visible;
                        txtAllInclusive.Text = "Yes";
                    }
                    else
                    {
                        txtbAllInclusive.Visibility = Visibility.Visible;
                        txtAllInclusive.Text = "No";
                    }
                }
            }
            if (travel.GetType() == typeof(WorkTrip))
            {
                WorkTrip worktrip = (WorkTrip)travel;
                txtDestination.Text = worktrip.Destination;
                txtCountry.Text = worktrip.Country.ToString();
                txtTravelers.Text = worktrip.Travelers.ToString();
                txtbMeetingDetails.Visibility = Visibility.Visible;
                txtMeetingDetails.Visibility = Visibility.Visible;

            }
        }


        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelsWindow = new TravelsWindow();
            travelsWindow.Show();
            Close();
        }
    }

}

