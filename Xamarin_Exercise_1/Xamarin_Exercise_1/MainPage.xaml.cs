using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Exercise_1
{
    public partial class MainPage : ContentPage
    {
        public string[] quotes;
        int counter;
        public MainPage()
        {
            InitializeComponent();
            counter= 0;
            slider.Value = 16;
            quotes = new string[]
            {
            "You can't blame gravity for falling in love.",
            "Qoute 2",
            "Qoute 3"
            };
            quoteLabel.Text = quotes[counter];    
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            if (counter == quotes.Length - 1)
                counter = 0;
            else
                counter++;

            quoteLabel.Text = quotes[counter];
        }
    }
}
