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
    public partial class Vantagens : ContentPage
    {
        public Vantagens()
        {
            InitializeComponent();
            listV.ItemsSource = IndiceVantagens.ListaV;
        }

        private void OnSelected (object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                Navigation.PushModalAsync(new PerfilVantagem());
                
                #region DisableSelectionHighlighting
                ((ListView)sender).SelectedItem=null;
                #endregion
            }
        }
    }   
}