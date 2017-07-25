using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

namespace GUI
{
    public partial class editarUsuario : System.Web.UI.Page
    {
        loginDAO login = new loginDAO();
        LitarTODO objeditar = new LitarTODO();
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Session["id"].ToString();
            id = int.Parse(txtUsuario.Text);
            txtNombre.Text = objeditar.listarNombre(id).ToString();
            txtNombre.DataBind();

        }
    }
}