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
    /// Interaction logic for PropertyReceipt.xaml
    /// </summary>
    public partial class PropertyReceipt : Window
    {
        public PropertyReceipt()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            double totalLoan = 0;
            totalLoan = (PropertyPurchase.propertyPrice - PropertyPurchase.depositPrice) * (1 + (PropertyPurchase.interestRate/100) *(PropertyPurchase.numberOfMonths/12));
            totalLoanBox.Text ="R " + totalLoan.ToString();

            double monthlyPay = 0;
            monthlyPay = totalLoan / PropertyPurchase.numberOfMonths;
            monthlyLoanBox.Text = "R " + monthlyPay.ToString();

            double available = 0;
            available = HomeLoanWPF.grossIncome - HomeLoanWPF.expensesTotal - HomeLoanWPF.monthlyTax - monthlyPay;
            availableBox.Text ="R " + available.ToString();

            if(monthlyPay > HomeLoanWPF.grossIncome / 3)
            {
                notifyBox.Text = "Approval Of Loan is very unlikely";
            }

            double GrossInc = 0;
            GrossInc = HomeLoanWPF.grossIncome;
            grossBox.Text ="R " + GrossInc.ToString();

            double totalExpenditure = 0;
            totalExpenditure = HomeLoanWPF.expensesTotal + monthlyPay;
            totalExpenditureBox.Text ="R " +totalExpenditure.ToString();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            PropertyPurchase purchase = new PropertyPurchase();
            this.Hide();
            purchase.Show();
        }

        private void backBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            VehicleLoanWPF vehicle = new VehicleLoanWPF();
            this.Hide();
            vehicle.Show();
        }
    }
   
}

