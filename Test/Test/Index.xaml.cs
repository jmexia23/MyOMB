﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Index : ContentPage
	{
		public Index ()
		{
			InitializeComponent ();
		}

        private void IndexLogIn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LogIn());
        }
    }
}