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
	public partial class Lojas : ContentPage
	{
		public Lojas ()
		{
			InitializeComponent ();
		}

        private void LojasIndice_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LojasIndice());
        }

        private void Vantagens_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Vantagens());
        }

        private void Parceiros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Parceiros());
        }
    }

}