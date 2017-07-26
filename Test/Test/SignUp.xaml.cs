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
	public partial class SignUp : ContentPage
	{
		public SignUp ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sucesso", "Sign Up concluído", "Ok");
            Navigation.PopModalAsync();
        }
    }
}