using _17Junio.Dal;
using _17Junio.Ef;
using _17Junio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace _17Junio.Services
{
    public class ProductosServices
    {
        public static Productos Factory(TextBox txtId, TextBox txtNombre, TextBox txtPrecio, TextBox txtCantidad)
        {
            var nuevoProducto = new Productos();
            nuevoProducto.ProductoId = Convert.ToInt32(txtId.Text);
            nuevoProducto.Nombre = txtNombre.Text;
            nuevoProducto.Precio = Convert.ToDecimal(txtPrecio.Text);
            nuevoProducto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            return nuevoProducto;
        }
    }
}