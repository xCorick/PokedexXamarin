using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PracticaXamarin.Model;

namespace PracticaXamarin.ViewModel.VMpokemon
{
    public class VMDetallepokemon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        string _objcolorfondo;
        string _objcolorpoder;
        string _objnombre;
        string _objnro;
        string _objpoder;
        string _objicono;
        public Mpokemon pokemonRecibe { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMDetallepokemon(INavigation navigation, Mpokemon pokemonTrae)
        {
            Navigation = navigation;
            pokemonRecibe = pokemonTrae;
            _objcolorfondo = pokemonRecibe.Colorfondo;
            _objcolorpoder = pokemonRecibe.Colorpoder;
            _objnombre = pokemonRecibe.Nombre;
            _objnro = pokemonRecibe.Nroorden;
            _objpoder = pokemonRecibe.Poder;
            _objicono = pokemonRecibe.Icono;
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { { SetValue(ref _Texto, value); } }
        }

        public string ColorFondo
        {
            get { return _objcolorfondo; }
            set
            {
                SetValue(ref _objcolorfondo, value);
                OnPropertyChanged(nameof(ColorFondo));
            }

        }

        public string ColorPoder
        {
            get { return _objcolorpoder; }
            set
            {
                SetValue(ref _objcolorpoder, value);
                OnPropertyChanged(nameof(ColorPoder));
            }
        }

        public string Nombre
        {
            get { return _objnombre; }
            set { SetValue(ref _objnombre, value); }
        }

        public string Numero
        {
            get { return _objnro; }
            set { SetValue(ref _objnro, value); }
        }

        public string Poder
        {
            get { return _objpoder; }
            set { SetValue(ref _objpoder, value); }
        }

        public string Icono
        {
            get { return _objicono; }
            set { SetValue(ref _objicono, value); }
        }

        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
