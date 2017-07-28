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
	public partial class ComCartão : ContentPage
	{
		public ComCartão ()
		{
			InitializeComponent ();
            ListV.ItemsSource = IndiceVales.ListaV;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        { 
                #region DisableSelectionHighlighting
                ((ListView)sender).SelectedItem = null;
                #endregion
           
        }
    }
}