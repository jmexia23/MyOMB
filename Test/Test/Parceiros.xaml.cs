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
    public partial class Parceiros : ContentPage
    {
        public Parceiros()
        {
            InitializeComponent();
            listP.ItemsSource = IndiceParceiros.ListaP;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Navigation.PushModalAsync(new PerfilParceiro());

                #region DisableSelectionHighlighting
                ((ListView)sender).SelectedItem = null;
                #endregion
            }
        }

    }
}
