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
	public partial class MenuView : MasterDetailPage
	{
		public MenuView ()
		{
			InitializeComponent ();
            MyMenu();
        }
        public void MyMenu()
        {
            Detail = new NavigationPage(new InicioView());
            List<Menu> menu = new List<Menu>
            {
                new Menu{ Page= new MiPerfil(),MenuTitle="Jovana.",  MenuDetail="Mi perfil",icon="botanita.jpg"},
                new Menu{ Page= new InicioView(),MenuTitle="Inicio.",  MenuDetail="",icon="botanita.jpg"},
            };
            ListMenu.ItemsSource = menu;
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
        }
        public class Menu
        {
            public string MenuTitle
            {
                get;
                set;
            }
            public string MenuDetail
            {
                get;
                set;
            }

            public ImageSource icon
            {
                get;
                set;
            }

            public Page Page
            {
                get;
                set;
            }
        }
    }
}