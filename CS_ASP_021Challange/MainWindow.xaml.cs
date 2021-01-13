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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CS_ASP_021Challange
{
  
   
   
  
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

        }

        // Driver Ticket
        private void printDriverTicketButton_Click(object sender, RoutedEventArgs e)
        {
            // Instantiate Variables
            string phoneNumber = phoneNumberTextBox.Text;
            string driverName = driverNameTextBox.Text;
            string socialSN = socialSecurityTextBox.Text;
            string startMiles = startMilesTextBox.Text;
            string endMiles = endMilesTextBox.Text;

            // Format Driver Info


            // Bring Driver Name to Result label
            driverNameResultLabel.Content = $"Driver - {driverName}";

            // Bring formatted SSN to Result label

            int ss = int.Parse(socialSN);

            socialSecurityResultLabel.Content = string.Format("{0:000-00-0000}" , ss);

            // Phone Number

            int ph = int.Parse(phoneNumber);

            phoneNumberResultLabel.Content = string.Format("{0:(000)000-0000}" , ph);

           

            // Get Total Days

            int days = Convert.ToInt32((dateReturnedCalendar.SelectedDate.Value - dateLeftCalendar.SelectedDate.Value).Days);

            totalNumberOfDaysOutResultLabel.Content = $"Days Out: {days}";

            // Get Days Off

            int vacationDays = days / 5;

            numberOfVacationDaysEarnedLabel.Content = $"Vacation Earned: {vacationDays} Days";

          

            // Start Miles 
            int SM = int.Parse(startMiles);

            // End Miles
            int EM = int.Parse(endMiles);

            // Get Total Miles

            int miles = Convert.ToInt32(endMiles) - Convert.ToInt32(startMiles);

            totalMilesResultLabel.Content = $"Total Miles: {miles}";

            // Get Total Pay

            double pay = (refrigeratedCheckBox.IsChecked == true) ? miles * .37 : miles * .25;

            totalPayDueResultLabel.Content = string.Format("Pay Due: {0:c}", pay);

        }
    }
}
