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
	public partial class Cartão : ContentPage
	{
		public Cartão ()
		{
            InitializeComponent();
        }

        private void PedirCartão_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ComCartão());
        }
    }
}