using System;
using System.Collections.Generic;
using ExamenIosX.Models;
using ExamenIosX.Repositories;
using ExamenIosX.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenIosX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class AltaView : ContentPage
    {
        RepositoryApuesta repositoryApuesta;
        public AltaView()
        {
            InitializeComponent();
            stepperLocal.ValueChanged += cambioLocal;
            stepperVisitante.ValueChanged += cambioVisitante;

            repositoryApuesta = new RepositoryApuesta();
            realizarApuesta.Clicked += RealizarApuesta_Clicked;
        }
        private void cambioLocal(object sender, ValueChangedEventArgs e)
        {
            apuestaEquipo1.Text = e.NewValue.ToString("0");
        }
        private void cambioVisitante(object sender, ValueChangedEventArgs e)
        {
            apuestaEquipo2.Text = e.NewValue.ToString("0");
        }
        private async void RealizarApuesta_Clicked(object sender, EventArgs e)
        {
            ApuestasView apuestasView = new ApuestasView();

            await Navigation.PushAsync(apuestasView);
        }
    }
}