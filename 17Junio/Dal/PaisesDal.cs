
using _17Junio.Ef;
using _17Junio.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17Junio.Dal
{
    public class PaisesDAL
    {
        public static List<Paises> ListarTodo()
        {

            var listado = new List<Paises> ();
            using (var modelo = new Model1()) {
                listado = modelo.Paises.ToList();
            }
            

            return listado;

        }

    }
}