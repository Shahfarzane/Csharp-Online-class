using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Labb3Tipcalc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ButtonEightPrecent(object sender, EventArgs args)
        {
            VatRate.Text = "8%";
            TotalAmount.Text = UserEntry.Text + " SEK";

            calculate(UserEntry.Text, 8);
        }

        private void ButtonTwelvePrecent(object sender, EventArgs args)
        {
            VatRate.Text = "12%";
            TotalAmount.Text = UserEntry.Text + " SEK";

            calculate(UserEntry.Text, 12);
        }

        private void ButtonTwentyFivePrecent(object sender, EventArgs args)
        {
            VatRate.Text = "25%";
            TotalAmount.Text = UserEntry.Text + " SEK";

            calculate(UserEntry.Text, 25);
        }

        private void calculate(String amount, int precent)
        {

            var amountToCalculate = double.Parse(amount);
            double percentage;
            double total;

            switch (precent)
            {
                case 8:
                    percentage = amountToCalculate * 0.08;
                    CalculatedVat.Text = $"{percentage.ToString()} SEK";

                    total = amountToCalculate * 0.92;
                    WhitoutVat.Text = $"{total.ToString()} SEK";
                    break;
                case 12:
                    percentage = amountToCalculate * 0.12;
                    CalculatedVat.Text = $"{percentage.ToString()} SEK";

                    total = amountToCalculate * 0.88;
                    WhitoutVat.Text = $"{total.ToString()} SEK";
                    break;
                case 25:
                    percentage = amountToCalculate * 0.25;
                    CalculatedVat.Text = $"{percentage.ToString()} SEK";

                    total = amountToCalculate * 0.75;
                    WhitoutVat.Text = $"{total.ToString()} SEK";
                    break;
                default:
                    break;
            }
        }
    }
}