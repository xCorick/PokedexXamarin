using PracticaXamarin.Model;
using PracticaXamarin.View;
using PracticaXamarin.View.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PracticaXamarin.ViewModel
{
    public class VMMenuPrincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MMenuPrincipal> listapaginas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMMenuPrincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { { SetValue(ref _Texto, value); } }
        }
        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void MostrarPaginas()
        {
            listapaginas = new List<MMenuPrincipal>
            {
                new MMenuPrincipal
                {
                    Pagina = "Entry, DatePicker, Picker, Labels, Navegacion",
                    Icono = "https://scontent-iad3-1.cdninstagram.com/v/t39.30808-6/454029074_18245154817250467_4042463734579390131_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=18de74&_nc_ohc=FRISXWpxbnsQ7kNvgF6Vjoj&_nc_ht=scontent-iad3-1.cdninstagram.com&edm=AL-3X8kEAAAA&_nc_gid=AAMhFLFaZEm5wV-zHdnYkdV&oh=00_AYBY7shRZGr31SNaARkxUYQ0WFzPE4UjNfpEylho7RSAgw&oe=67235E55"
                },
                new MMenuPrincipal
                {
                    Pagina = "CollectionView sin enlace a Base de Datos",
                    Icono = "https://scontent-iad3-1.cdninstagram.com/v/t51.29350-15/449346618_1209344316854819_2428672803700757977_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=18de74&_nc_ohc=cSH0N2uWtPsQ7kNvgFgn2lF&_nc_ht=scontent-iad3-1.cdninstagram.com&edm=AL-3X8kEAAAA&_nc_gid=AAMhFLFaZEm5wV-zHdnYkdV&oh=00_AYBnr93FUBp9NdQV557waE9HasNMdW9rpjPOJE0F8TbBwQ&oe=67236677"
                },
                new MMenuPrincipal
                {
                    Pagina = "CRUD Pokemon",
                    Icono = "https://steamuserimages-a.akamaihd.net/ugc/771730080920478145/63908B4FC5FB5DE2D19010234AFFAD2B69D96E55/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false"
                },
                new MMenuPrincipal
                {
                    Pagina = "Registrar Pokemon",
                    Icono = "https://w7.pngwing.com/pngs/363/696/png-transparent-pokemon-go-computer-icons-psyduck-pokemon-go.png"
                },
                new MMenuPrincipal
                {
                    Pagina = "Lista Pokemon",
                    Icono = "https://cdn.iconscout.com/icon/premium/png-256-thumb/pokedex-4-674594.png?f=webp"
                },
                new MMenuPrincipal
                {
                    Pagina = "Detalle pokemon",
                    Icono = "https://cdn-icons-png.flaticon.com/512/2094/2094510.png"
                }
            };
        }

        public async Task Navegar(MMenuPrincipal param)
        {
            string pagina;
            pagina = param.Pagina;
            if (pagina.Contains("Entry, DatePicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            else if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            else if (pagina.Contains("CRUD Pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
            else if (pagina.Contains("Registrar Pokemon"))
            {
                await Navigation.PushAsync(new Registrarpokemon());
            }
            else if (pagina.Contains("Lista Pokemon"))
            {
                await Navigation.PushAsync(new Listapokemon());
            }
        }
        #endregion

        #region COMANDOS
        //public ICommand VolverCommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand NavegarCommand => new Command<MMenuPrincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
