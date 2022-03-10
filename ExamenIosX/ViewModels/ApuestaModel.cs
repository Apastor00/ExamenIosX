using System;
using ExamenIosX.Models;
using ExamenIosX.Repositories;
using ExamenIosX.ViewModels.Base;
using Xamarin.Forms;

namespace ExamenIosX.ViewModels
{
    public class ApuestaModel : ViewModelBase
    {
        RepositoryApuesta repositoryApuesta;
        public ApuestaModel()
        {
            repositoryApuesta = new RepositoryApuesta();
            apuesta = new Apuesta();
        }
        private Apuesta _apuesta;
        public Apuesta apuesta
        {
            get { return _apuesta; }
            set
            {
                _apuesta = value;
                OnPropertyChanged("apuesta");
            }
        }
        public Command InsertarDato
        {
            get
            {
                return new Command(() => {
                    repositoryApuesta.InsertarApuesta(apuesta);
                });
            }
        }
    }
}
