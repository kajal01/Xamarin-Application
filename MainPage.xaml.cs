using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void calculate_Clicked(object sender, EventArgs e)
        {
            double interestAmount = Convert.ToDouble(principal_amount.Text) *
                Convert.ToDouble(time_period.Text) *
                Convert.ToDouble(rate_of_interest.Text) / 100;
            double totalAmount = Convert.ToDouble(principal_amount.Text) + interestAmount;

            lblSimpleInterest.Text = interestAmount.ToString();
            lblTotalAmount.Text = totalAmount.ToString();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            principal_amount.Text = string.Empty;
            time_period.Text = string.Empty;
            rate_of_interest.Text = string.Empty;
            lblSimpleInterest.Text = string.Empty;
            lblTotalAmount.Text = string.Empty;
        }
    }
}
