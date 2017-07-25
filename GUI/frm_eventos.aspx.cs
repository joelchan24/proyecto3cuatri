using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class frm_eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mandar(object sender, EventArgs e)
        {
            if (Session["usuario"] == null && Session["id"] == null)
            {
                Response.Redirect("registro_usuarios_fueramasterpge.aspx", true);
            }
            else if (Session["tipo"].ToString() == "USUARIO" && Session["usuario"] != null && Session["id"] != null)
            {
                Response.Redirect("frm_mensaje.aspx", true);
            }

        }

        [System.Web.Services.WebMethod]
        public static ComentarioModel AgregarMensaje(string Texto)
        {
            ComentarioModel modelo = new ComentarioModel();

            modelo.Mensaje = Texto;
            modelo.Usuario = "Admin"; //(string)Session["usuario"];
            return modelo;
        }
    }


    public class ComentarioModel
    {
        public string Usuario { get; set; }
        public string Mensaje { get; set; }
    }
}