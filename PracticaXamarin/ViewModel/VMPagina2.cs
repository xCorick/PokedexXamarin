using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PracticaXamarin.Model;

namespace PracticaXamarin.ViewModel
{
    class VMPagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MUsuarios> listausuarios {  get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMPagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
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
        public void MostrarUsuarios()
        {
            listausuarios = new List<MUsuarios>
            {
                new MUsuarios
                {
                    Nombre = "ACAね",
                    Imagen = "https://scontent-iad3-1.cdninstagram.com/v/t39.30808-6/454029074_18245154817250467_4042463734579390131_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=18de74&_nc_ohc=FRISXWpxbnsQ7kNvgF6Vjoj&_nc_ht=scontent-iad3-1.cdninstagram.com&edm=AL-3X8kEAAAA&_nc_gid=AAMhFLFaZEm5wV-zHdnYkdV&oh=00_AYBY7shRZGr31SNaARkxUYQ0WFzPE4UjNfpEylho7RSAgw&oe=67235E55"
                },
                new MUsuarios
                {
                    Nombre = "Corick",
                    Imagen = "https://scontent-iad3-1.cdninstagram.com/v/t51.29350-15/449346618_1209344316854819_2428672803700757977_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=18de74&_nc_ohc=cSH0N2uWtPsQ7kNvgFgn2lF&_nc_ht=scontent-iad3-1.cdninstagram.com&edm=AL-3X8kEAAAA&_nc_gid=AAMhFLFaZEm5wV-zHdnYkdV&oh=00_AYBnr93FUBp9NdQV557waE9HasNMdW9rpjPOJE0F8TbBwQ&oe=67236677"
                },
                new MUsuarios
                {
                    Nombre = "Master Chief",
                    Imagen = "https://steamuserimages-a.akamaihd.net/ugc/771730080920478145/63908B4FC5FB5DE2D19010234AFFAD2B69D96E55/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false"
                }
            };
        }

        public async Task Alerta(MUsuarios param)
        {
            await DisplayAlert("Hola", param.Nombre, "jeje");
        }
        #endregion

        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand AlertaCommand => new Command<MUsuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
