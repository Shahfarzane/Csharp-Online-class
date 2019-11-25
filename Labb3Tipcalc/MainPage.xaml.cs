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
            vatRate.Text = "8%";
            totalAmount.Text = userEntry.Text + " SEK";

            calculate(userEntry.Text, 8);
        }

        private void ButtonTwelvePrecent(object sender, EventArgs args)
        {
            vatRate.Text = "12%";
            totalAmount.Text = userEntry.Text + " SEK";

            calculate(userEntry.Text, 12);
        }

        private void ButtonTwentyFivePrecent(object sender, EventArgs args)
        {
            vatRate.Text = "25%";
            totalAmount.Text = userEntry.Text + " SEK";

            calculate(userEntry.Text, 25);
        }

        private void calculate(string amount, int precent)
        {

            var amountToCalculate = double.Parse(amount);
            double percentage;
            double total;

            switch (precent)
            {
                case 8:
                    percentage = amountToCalculate * 0.08;
                    calculatedVat.Text = $"{percentage.ToString()} SEK";

                    total = amountToCalculate * 0.92;
                    whitoutVat.Text = $"{total.ToString()} SEK";
                    break;
                case 12:
                    percentage = amountToCalculate * 0.12;
                    calculatedVat.Text = $"{percentage.ToString()} SEK";

                    total = amountToCalculate * 0.88;
                    whitoutVat.Text = $"{total.ToString()} SEK";
                    break;
                case 25:
                    percentage = amountToCalculate * 0.25;
                    calculatedVat.Text = $"{percentage.ToString()} SEK";

                    total = amountToCalculate * 0.75;
                    whitoutVat.Text = $"{total.ToString()} SEK";
                    break;
                default:
                    break;
            }
        }
    }
}