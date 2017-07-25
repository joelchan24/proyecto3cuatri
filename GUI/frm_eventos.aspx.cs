using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

namespace GUI
{
    public partial class frm_eventos : System.Web.UI.Page
    {
        int id;
        eventoDAO evento = new eventoDAO();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                id = 0;

            }
            else if (Request.QueryString["id"] != null)
            {
               id = Convert.ToInt32( Request.QueryString["id"]);
                rpt.DataSource = evento.datoseventoselecionado(id).Tables[0];
                rpt.DataBind();

            }

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