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
		}

        private void Switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (SwV.IsToggled== true)
            {
                DisplayAlert("ds","false","d");
            }
            else
            {
                DisplayAlert("ds", "true", "d");
            }
        }
    }
}