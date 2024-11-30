using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PracticaXamarin.View.Pokemon;
using PracticaXamarin.Datos;
using PracticaXamarin.Model;
using System.Collections.ObjectModel;

namespace PracticaXamarin.ViewModel.VMpokemon
{
    public class VMListapokemon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mpokemon> _Listapokemon;
        #endregion

        #region CONSTRUCTOR
        public VMListapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion

        #region OBJETOS
        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set {  SetValue(ref _Listapokemon, value);
                    OnpropertyChanged();
            }
        }
        #endregion

        #region PROCESOS
        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        }
        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }
        //public void ProcesoSimple()
        //{

        //}
        public async Task Iradetalle(Mpokemon pokemon)
        {
            await Navigation.PushAsync(new Detallepokemon(pokemon));
        }
        #endregion

        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Iradetallecommand => new Command<Mpokemon>(async (p) => await Iradetalle(p));
        #endregion
    }
}
