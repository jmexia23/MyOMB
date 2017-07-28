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
	public partial class SemCartão : ContentPage
	{
		public SemCartão ()
		{
			InitializeComponent ();
		}

        private void NovoCartão_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Cartão());
        }
    }
}