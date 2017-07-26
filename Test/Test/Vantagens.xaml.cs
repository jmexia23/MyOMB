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
	public partial class Vantagens : ContentPage
	{
		public Vantagens ()
		{
			InitializeComponent ();
            Lista.ItemsSource = IndiceVantagens.Lista;
        }
        private void Vantagem_Clicked (object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PerfilVantagem());
        }
    }
}