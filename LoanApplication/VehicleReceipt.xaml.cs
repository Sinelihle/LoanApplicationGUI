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

namespace LoanApplication
{
    /// <summary>
    /// Interaction logic for VehicleReceipt.xaml
    /// </summary>
    public delegate void NotificationDel();
    public partial class VehicleReceipt : Window
    {
        public VehicleReceipt()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            double loan = 0;
            loan = (VehicleLoanWPF.vehiclePrice - PropertyPurchase.depositPrice) * (1 + (PropertyPurchase.interestRate / 100) * (5));
            //double totalCost = loan + VehicleLoanWPF.insurancePremium;
            double monthly = 0;
            monthly = (loan + VehicleLoanWPF.insurancePremium)/ 12;
            vehicleMonthyCostBox.Text="R " + monthly.ToString();
            totalCostBox.Text ="R " + loan.ToString();
            purchasePriceBox.Text = "R "+ VehicleLoanWPF.vehiclePrice.ToString();
            depositBox.Text = "R "+ PropertyPurchase.depositPrice.ToString();
            interestRateBox.Text = PropertyPurchase.interestRate.ToString() + "%";
            NotificationDel notify = new NotificationDel(Notification);
            notify.Invoke();
        }
        public void Notification()
        {
            try
            {
                double totalMonthlyExpenses = VehicleLoanWPF.totalExpenses + (Convert.ToDouble(vehicleMonthyCostBox.Text) / 12);
                if (totalMonthlyExpenses > HomeLoanWPF.grossIncome * 0.75)
                {
                    notifyBox.Text = "Your expenses exceed 75% of your income";
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VehicleLoanWPF vh = new VehicleLoanWPF();
            this.Hide();
            vh.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}

//public double CalculateLoan()
//{
//    double loan = (purchasePrice - totalDeposit) * (1 + (interestRate / 100) * (5));
//    return loan;
//}