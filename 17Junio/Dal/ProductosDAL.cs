using _17Junio.Ef;
using _17Junio.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17Junio.Dal
{
    public class ProductosDAL
    {
        public static List<Productos> ListarTodo()
        {

            var listadoProductos = new List<Productos>();
            using (var modelo = new Model1())
            {
                listadoProductos = modelo.Productos.ToList();
            }


            return listadoProductos;

        }
    }
}