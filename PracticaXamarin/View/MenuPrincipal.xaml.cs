using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaXamarin.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticaXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            BindingContext = new VMMenuPrincipal(Navigation);
        }
    }
}