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
    /// Interaction logic for RentWPF.xaml
    /// </summary>
    public partial class RentWPF : Window
    {
        public static double rentAmount = 0;
        public RentWPF()
        {
            InitializeComponent();
        }

        private void rentBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                rentAmount = Convert.ToDouble(rentBox.Text);
            }
            catch (Exception)
            {

            }
           
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            displayRentBox.Text = "Rent Amount  \t" + rentBox.Text;
            displayGrossBox.Text = "Gross Income  \t" + HomeLoanWPF.grossIncome.ToString();
            displayTax.Text ="Tax \t" + HomeLoanWPF.monthlyTax.ToString();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            HomeLoanWPF h = new HomeLoanWPF();
            this.Hide();
            h.Show();
        }
    }
}
