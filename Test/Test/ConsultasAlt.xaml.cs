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
	public partial class ConsultasAlt : ContentPage
	{
		public ConsultasAlt ()
		{
			InitializeComponent ();
		}
        private void Associar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp());
        }

        private void Marcar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Marcar());
        }
    }
}