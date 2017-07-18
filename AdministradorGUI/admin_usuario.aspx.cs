using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using AdministradorGUI;

namespace AdministradorGUI
{
    public partial class Usuario : System.Web.UI.Page
    {
        usuarioDAO obj =new usuarioDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void listar()
        {
            if (!IsPostBack)
            { 
               
            } 

        }

        protected void hola(object sender, EventArgs e)
        {
        }
    }
}