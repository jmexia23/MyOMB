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
	public partial class Index2 : ContentPage
	{
		public Index2 ()
		{
			InitializeComponent ();
		}

        private void IndexPerfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LogIn());
        }

        private void IndexCompras_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Compras());
        }

        private void IndexCartao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SemCartão());
        }

        private void IndexConsultas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ConsultasAlt());
        }

        private void IndexLojas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Lojas());
        }
    }
}