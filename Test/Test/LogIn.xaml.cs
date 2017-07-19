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
	public partial class LogIn : ContentPage
	{
		public LogIn ()
		{
			InitializeComponent ();
		}

        private void OnSignUpClicked(Object sender , EventArgs e)
        {
            Navigation.PushModalAsync(new SignUp());        }

        private void OnLoginClicked(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Index());
        }


    }
}