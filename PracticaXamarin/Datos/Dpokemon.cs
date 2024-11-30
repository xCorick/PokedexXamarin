using System;
using System.Collections.Generic;
using System.Text;
using PracticaXamarin.Model;
using PracticaXamarin.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace PracticaXamarin.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon pokemon)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    Colorfondo = pokemon.Colorfondo,
                    Colorpoder = pokemon.Colorpoder,
                    Icono = pokemon.Icono,
                    Nombre = pokemon.Nombre,
                    Nroorden = pokemon.Nroorden,
                    Poder = pokemon.Poder
                }
                );
        }
        public async Task<ObservableCollection<Mpokemon>> MostrarPokemones()
        {
            //return (await Cconexion.firebase
            //    .Child("Pokemon")
            //    .OnceAsync<Mpokemon>())
            //    .Select(item => new Mpokemon()
            //    {
            //        idpokemon = item.Key,
            //        Nombre = item.Object?.Nombre,
            //        Colorfondo = item.Object?.Colorfondo,
            //        Colorpoder= item.Object?.Colorpoder,
            //        Nroorden= item.Object?.Nroorden,
            //        Poder = item.Object?.Poder,
            //        Icono = item.Object?.Icono
            //    }).ToList();
            var data = await Task.Run(() => Cconexion.firebase
                .Child("Pokemon")
                .AsObservable<Mpokemon>()
                .AsObservableCollection()
                );
            return data;
        }
    }
}
