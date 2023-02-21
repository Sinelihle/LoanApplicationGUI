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
    /// Interaction logic for PropertyPurchase.xaml
    /// </summary>
    public partial class PropertyPurchase : Window
    {
        public static double propertyPrice = 0;
        public static double depositPrice = 0;
        public static double interestRate = 0;
        public static int numberOfMonths = 0;

        public PropertyPurchase()
        {
            InitializeComponent();
        }

        private void repaymentSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {


            if (repaymentTextBox != null)
            {
                repaymentTextBox.Text = repaymentSlider.Value.ToString();
                numberOfMonths = Convert.ToInt32(repaymentTextBox.Text);
            }

        }

        private void interestSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            if (interestTextBox != null)
            {
                interestTextBox.Text = interestSlider.Value.ToString();
                interestRate = Convert.ToDouble(interestTextBox.Text);
            }
        }

        private void TextBlock_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            purchaseDisplayBlock.Text = "Property Purchase Price: R " + txtPurchasePrice.Text;
            depositBlock.Text = "Deposit: R " + txtDeposit.Text;
            interestDialogBlock.Text = "Interest Rate: " + interestSlider.Value.ToString() + "%";
            repaymentBlock.Text = "Repayment Months: " + repaymentSlider.Value.ToString() + " Months";
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            PropertyReceipt receipt = new PropertyReceipt();
            this.Hide();
            receipt.Show();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            HomeLoanWPF home = new HomeLoanWPF();
            this.Hide();
            home.Show();
        }

        private void txtPurchasePrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                propertyPrice = Convert.ToDouble(txtPurchasePrice.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Please Enter Valid Value");
            }
            
        }

        private void txtDeposit_TextChanged(object sender, TextChangedEventArgs e)
        {
            depositPrice = Convert.ToDouble(txtDeposit.Text);
        }
    }
}