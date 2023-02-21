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
    /// Interaction logic for HomeLoanWPF.xaml
    /// </summary>
    public partial class HomeLoanWPF : Window
    {

        public static double grossIncome = 0;
        public static double monthlyTax = 0;
        public static double groceries = 0;
        public static double waterAndLights = 0;
        public static double travelCost = 0;
        public static double phone = 0;
        public static double other = 0;
        public static double expensesTotal = 0;
        public HomeLoanWPF()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            try
            {
                double grossValue = 0;
                grossValue = Convert.ToDouble(txtGross.Text);
                //testing the to String method
                expensesTotal = Convert.ToDouble(txtGroceries.Text) + Convert.ToDouble(txtWater.Text) + Convert.ToDouble(txtTravel.Text) +
                Convert.ToDouble(txtPhone.Text) + Convert.ToDouble(txtOther.Text);

                if (expensesTotal > grossValue)
                {
                    MessageBox.Show("Expenses Exceed Gross Income");
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (expensesTotal < Convert.ToDouble(txtGross.Text))
                {
                    this.Hide();
                    PropertyPurchase property = new PropertyPurchase();
                    property.Show();
                }
                else
                {
                    ClearExpenses();
                    this.Show();
                }
            }
            catch (Exception)
            {

            }

           
            
        }

        private void txtGross_TextChanged(object sender, TextChangedEventArgs e)
        {
            grossIncome = Convert.ToDouble(txtGross.Text);
        }

        private void txtTax_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                monthlyTax = Convert.ToDouble(txtTax.Text);

                if (monthlyTax > grossIncome)
                {
                    txtTax.Text = "";
                    warnLbl.Content = "Tax exceeds income";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void txtGroceries_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                groceries = Convert.ToDouble(txtGross.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtWater_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                waterAndLights = Convert.ToDouble(txtWater.Text);
                txtWater.Text = waterAndLights.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void txtTravel_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                travelCost = Convert.ToDouble(txtTravel.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
             
            }
           
        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                phone = Convert.ToDouble(txtPhone.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void txtOther_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                other = Convert.ToDouble(txtOther.Text);
            }
            catch (Exception)
            {

            }
            
        }

        public void ClearExpenses()
        {
            txtGroceries.Text = "";
            txtWater.Text = "";
            txtTravel.Text = "";
            txtPhone.Text = "";
            txtOther.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RentWPF rent = new RentWPF();
            this.Hide();
            rent.Show();
        }
    }
}
