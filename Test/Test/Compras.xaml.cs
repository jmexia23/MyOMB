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
	public partial class Compras : ContentPage
	{
		public Compras ()
		{
			InitializeComponent ();
		}

        private void link_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://mydreamglasses.com/"));
        }

    }
}