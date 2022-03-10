using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExamenIosX.Views
{
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            baseDatos.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new AltaView());

            webApi.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new ApuestasView());
        }
    }
}
