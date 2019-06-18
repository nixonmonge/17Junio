using _17Junio.Ef;
using _17Junio.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _17Junio
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.DataSource = ProductosDAL.ListarTodo();
            GridView2.DataBind();

        }
    }
}