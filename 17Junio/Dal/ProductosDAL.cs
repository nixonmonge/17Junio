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
    public class ProductosDAL
    {
        public static List<Productos> ListarTodo()
        {

            var listadoProductos = new List<Productos>();
            using (var modelo = new Model1())
            {   // LINQ // Comandos
                // LEER : grupo entidad.(comandos linq).ToList();
                // LEER UN ELEMENTO: First() firstOrDefault()


                listadoProductos = modelo.Productos
                    .OrderBy(p=>p.Nombre) //donde p corresponde una fila
                    //.Where(p=> p.Nombre=="Cocacola")
                    .ToList(); // finalmente traer el listado


                //listadoProductos = modelo.Productos.ToList(); -- consulta original
            }


            return listadoProductos;




        }
        public static void Insertar(Productos obj)
        {
            using (var modelo = new Model1())
            {
                modelo.Productos.Add(obj);
                modelo.SaveChanges(); // guarda todos los cambios pendientes
            }

        }
    }
}