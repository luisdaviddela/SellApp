using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotanitApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentasView : ContentPage
    {
        public VentasView()
        {
            InitializeComponent();
        }
        int count = 0;

        private void btn1_Clicked(object sender, EventArgs e)
        {
            count = count - 1;
            if (count <= 0)
            {
                cantidad.Text = "La cantidad no puede ser 0";
            }
            else
            {
                cantidad.Text = count.ToString();
            }
        }

        private void btn1_Clicked_1(object sender, EventArgs e)
        {
            count = count +1;
            cantidad.Text = count.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Botanita App","Sus productos están apartados","Ok");
        }
    }
}