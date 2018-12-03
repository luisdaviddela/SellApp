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
	public partial class Venta_Dulces : ContentPage
	{
		public Venta_Dulces ()
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

            var dd3 = new TapGestureRecognizer();
            dd3.Tapped += (s, e) => {
                GoVentas();
            };
            d3.GestureRecognizers.Add(dd3);

            var dd4 = new TapGestureRecognizer();
            dd4.Tapped += (s, e) => {
                GoVentas();
            };
            d4.GestureRecognizers.Add(dd4);

            var dd5 = new TapGestureRecognizer();
            dd5.Tapped += (s, e) => {
                GoVentas();
            };
            d5.GestureRecognizers.Add(dd5);

            var dd6 = new TapGestureRecognizer();
            dd6.Tapped += (s, e) => {
                GoVentas();
            };
            d6.GestureRecognizers.Add(dd6);

            var dd7 = new TapGestureRecognizer();
            dd7.Tapped += (s, e) => {
                GoVentas();
            };
            d7.GestureRecognizers.Add(dd7);

            var dd8 = new TapGestureRecognizer();
            dd8.Tapped += (s, e) => {
                GoVentas();
            };
            d8.GestureRecognizers.Add(dd8);

            var dd9 = new TapGestureRecognizer();
            dd9.Tapped += (s, e) => {
                GoVentas();
            };
            d9.GestureRecognizers.Add(dd9);

            var dd10 = new TapGestureRecognizer();
            dd10.Tapped += (s, e) => {
                GoVentas();
            };
            d10.GestureRecognizers.Add(dd10);
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