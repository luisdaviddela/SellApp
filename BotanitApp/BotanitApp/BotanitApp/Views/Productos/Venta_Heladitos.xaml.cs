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
	public partial class Venta_Heladitos : ContentPage
	{
		public Venta_Heladitos ()
		{
			InitializeComponent ();
            var dd1 = new TapGestureRecognizer();
            dd1.Tapped += (s, e) => {
                GoVentas();
            };
            d1.GestureRecognizers.Add(dd1);

            var dd2 = new TapGestureRecognizer();
            dd2.Tapped += (s, e) => {
                GoVentas();
            };
            d2.GestureRecognizers.Add(dd2);
        }
        public void GoVentas()
        {
            Navigation.PushAsync(new VentasView());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("tel:8332350543"));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}