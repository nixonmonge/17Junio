using _17Junio.Dal;
using _17Junio.Ef;
using _17Junio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        public static void Insertar(Paises obj)
        {
            using (var modelo = new Model1())
            {
                modelo.Paises.Add(obj);
                modelo.SaveChanges(); // guarda todos los cambios pendientes
            }

        }

    }
}