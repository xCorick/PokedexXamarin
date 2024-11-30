using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace PracticaXamarin.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-574bc-default-rtdb.firebaseio.com/");
    }
}
