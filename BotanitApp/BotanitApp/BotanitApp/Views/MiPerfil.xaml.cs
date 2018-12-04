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
	public partial class MiPerfil : ContentPage
	{
		public MiPerfil ()
		{
			InitializeComponent ();
            var ActivoSesion = Application.Current.Properties["IsActivo"];
            bool Activo = Convert.ToBoolean(ActivoSesion);

            SwV.IsToggled= Activo;
        }

        private void Switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (SwV.IsToggled== true)
            {
                Application.Current.Properties["IsActivo"]= true;
            }
            else
            {
                Application.Current.Properties["IsActivo"] = false;
            }
        }
    }
}