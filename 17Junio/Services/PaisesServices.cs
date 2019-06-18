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
    public class PaisesServices
    {
        public static Paises Factory(TextBox txtId, TextBox txtNombre)
        {
            var nuevoPais = new Paises();
            nuevoPais.PaisId = Convert.ToInt32(txtId.Text);
            nuevoPais.Nombre = txtNombre.Text;

            return nuevoPais;
        }
    }
}