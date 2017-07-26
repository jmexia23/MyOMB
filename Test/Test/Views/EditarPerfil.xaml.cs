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
    public partial class EditarPerfil : ContentPage
    {
        public EditarPerfil()
        {
            InitializeComponent();
        }

        private void Alterar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sucesso", "Perfil Alterado", "Ok");
            Navigation.PopModalAsync();
        }

    }
}