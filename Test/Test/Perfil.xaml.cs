using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Perfil : ContentPage
	{
		public Perfil ()
		{
			InitializeComponent ();
		}

        private void Editar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EditarPerfil());
        }

        private void Terminar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Index2());
        }
    }
}