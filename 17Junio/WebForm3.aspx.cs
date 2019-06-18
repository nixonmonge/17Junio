using _17Junio.Dal;
using _17Junio.Ef;
using _17Junio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _17Junio
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var nuevoPais = PaisesServices.Factory(TextBox1, TextBox2);
            PaisesDAL.Insertar(nuevoPais);
        }
    }
}