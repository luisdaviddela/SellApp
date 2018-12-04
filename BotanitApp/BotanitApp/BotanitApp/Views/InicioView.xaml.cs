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
	public partial class InicioView : ContentPage
	{
		public InicioView ()
		{
			InitializeComponent ();

            #region

            var dulcess = new TapGestureRecognizer();
            dulcess.Tapped += (s, e) => {
                Navigation.PushAsync(new Venta_Dulces());
            };
            dulces.GestureRecognizers.Add(dulcess);

            var antojitoss = new TapGestureRecognizer();
            antojitoss.Tapped += (s, e) => {
                Navigation.PushAsync(new Venta_Antojitos());
            };
            antojitos.GestureRecognizers.Add(antojitoss);

            var heladitoss = new TapGestureRecognizer();
            heladitoss.Tapped += (s, e) => {
                Navigation.PushAsync(new Venta_Heladitos());
            };
            heladitos.GestureRecognizers.Add(heladitoss);

            var comidas = new TapGestureRecognizer();
            comidas.Tapped += (s, e) => {
                Navigation.PushAsync(new Venta_Comida());
            };
            comida.GestureRecognizers.Add(comidas);
            #endregion

            if (Application.Current.Properties.ContainsKey("IsActivo")==false)
            {
                Application.Current.Properties["IsActivo"] = true;
            }
        }
	}
}