﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PracticaXamarin.Model;
using PracticaXamarin.Datos;

namespace PracticaXamarin.ViewModel.VMpokemon
{
    public class VMRegistrarpokemon : BaseViewModel
    {
        #region VARIABLES
        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;
        #endregion

        #region CONSTRUCTOR
        public VMRegistrarpokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; }
            set { { SetValue(ref _Txtcolorfondo, value); } }
        }
        public string Txtcolorpoder
        {
            get { return _Txtcolorpoder; }
            set { { SetValue(ref _Txtcolorpoder, value); } }
        }
        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { { SetValue(ref _Txtnombre, value); } }
        }
        public string Txtnro
        {
            get { return _Txtnro; }
            set { { SetValue(ref _Txtnro, value); } }
        }
        public string Txtpoder
        {
            get { return _Txtpoder; }
            set { { SetValue(ref _Txtpoder, value); } }
        }
        public string Txticono
        {
            get { return _Txticono; }
            set { { SetValue(ref _Txticono, value); } }
        }

        #endregion

        #region PROCESOS
        public async Task Insertar()
        {
            var funcion = new Dpokemon();
            var pokemon = new Mpokemon();

            pokemon.Colorfondo = Txtcolorfondo;
            pokemon.Colorpoder = Txtcolorpoder;
            pokemon.Icono = Txticono;
            pokemon.Nombre = Txtnombre;
            pokemon.Nroorden = Txtnro;
            pokemon.Poder = Txtpoder;

            await funcion.Insertarpokemon(pokemon);
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
