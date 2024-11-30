using PracticaXamarin.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PracticaXamarin.ViewModel
{
    internal class VMPagina1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _Respuesta;
        string _Tipo;
        string _ResultadoFecha;
        DateTime _Fecha;
        #endregion

        #region CONSTRUCTOR
        public VMPagina1(INavigation navigation)
        {
            Navigation = navigation;
            Fecha = DateTime.Now;
        }
        #endregion

        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { { SetValue(ref _N1, value); } }
        }

        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }

        public string Respuesta
        {
            get { return _Respuesta; }
            set { SetValue(ref _Respuesta, value); }
        }

        public string Tipo
        {
            get { return _Tipo; }
            set {  SetValue(ref _Tipo, value);}
        }
        public string SelectTypeUser
        {
            get { return _Tipo; }
            set { SetProperty(ref _Tipo, value);
                Tipo = _Tipo;
            }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetValue(ref _Fecha, value);
                ResultadoFecha = _Fecha.ToString("dd/MM/yyyy");
            }
        }

        public string ResultadoFecha
        {
            get { return _ResultadoFecha; }
            set { { SetValue(ref _ResultadoFecha, value); } }
        }
        #endregion

        #region PROCESOS
        public async Task NavegarPagina2()
        {
            await Navigation.PushAsync(new Pagina2());
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void Suma()
        {
            double n1 = 0;
            double n2 = 0;
            double respuesta = 0;
            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);

            respuesta = n1 + n2;

            Respuesta = respuesta.ToString();
        }
        #endregion

        #region COMANDOS
        public ICommand NavegarPagina2Command => new Command(async () => await NavegarPagina2());
        public ICommand SumarCommand => new Command(Suma);
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
