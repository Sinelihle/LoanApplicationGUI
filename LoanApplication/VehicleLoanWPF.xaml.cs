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
    /// Interaction logic for VehicleLoanWPF.xaml
    /// </summary>
    public partial class VehicleLoanWPF : Window
    {
        public static double vehiclePrice = 0;
        public static double insurancePremium = 0;
        public static double totalExpenses = 0;
        public VehicleLoanWPF()
        {
            InitializeComponent();
        }

        private void txtPriceBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                vehiclePrice = Convert.ToDouble(txtPriceBox.Text);
            }
            catch (Exception)
            {

            }
           
        }

        private void txtDepositBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             PropertyPurchase.depositPrice = Convert.ToDouble(txtDepositBox.Text);
            
        }

        private void interestSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (interestTextBox != null)
            {
                interestTextBox.Text = interestSlider.Value.ToString();
                PropertyPurchase.interestRate = Convert.ToDouble(interestTextBox.Text);
            }
        }

        private void premiumBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                insurancePremium = Convert.ToDouble(premiumBox.Text);
            }
            catch (Exception)
            {

            }
           
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            modelBlock.Text ="Model And Make \t\t" + txtModelandMakeBox.Text;
            depositBlock.Text = "Total Deposit \t\t R" + txtDepositBox.Text;
            purchasePriceBlock.Text = "Purchase Price \t\t R" + txtPriceBox.Text;
            interestRateBlock.Text = "Interest Rate \t\t" + interestSlider.Value.ToString() + "%";
            insurancePremiumBlock.Text = "Insurance Premium \t R" + premiumBox.Text;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Hide();
            window.Show();
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            VehicleReceipt receipt = new VehicleReceipt();
            this.Hide();
            receipt.Show();
        }

        private void totalExpensesBtn_TextChanged(object sender, TextChangedEventArgs e)
        {
            totalExpenses = Convert.ToDouble(totalExpensesBtn.Text);
        }

        private void txtGrossIncome_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                HomeLoanWPF.grossIncome = Convert.ToDouble(txtGrossIncome.Text);

            }
            catch (Exception)
            {

            }
        }
    }
}
