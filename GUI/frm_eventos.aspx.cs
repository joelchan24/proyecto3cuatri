using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;
using Services;
namespace GUI
{
    public partial class frm_eventos : System.Web.UI.Page
    {
        int id;
        eventoDAO evento = new eventoDAO();
        ComentarioDAO comentario = new ComentarioDAO();
        
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
                rpiter.DataSource = evento.galeria(id).Tables[0];
                rpiter.DataBind();
                txtEvento.Value =this.id.ToString();
                EventoBO obj = new EventoBO();
                obj.Codigo = id;
                evento.modificarVisistas(obj);
                Session["evento"] = id;
            }
            if (!IsPostBack)
            {
                rptComentario.DataSource = comentario.listarcomentario(id).Tables[0];
                rptComentario.DataBind();
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
            modelo.Usuario = "COMENTARIO"; //(string)Session["usuario"];
            return modelo;
        }

        protected void seleccionar(object sender, EventArgs e)
        {
            try
            {



                Button sele = (Button)sender;
                CTRLComentario objcomentario = new CTRLComentario();
                txtusuario.Value = Session["id"].ToString();
                objcomentario.Comentario(listar(), sele.ID);
                Response.Write("<script>window.alert('usted a hecho un comentario');</script>");
                txtComentario.Text = null;
            }
            catch
            {
                Response.Write("<script>window.alert('es necesario registrarse para poder hacer un comentario');</script>");
            }

        }
        public ComentarioBO listar()
        {
            ComentarioBO obj = new ComentarioBO();
            int id = 0; int.TryParse(txtIDCmentario.Value, out id);
            obj.Codigo = id;
            obj.Comentario = txtComentario.Text;
            obj.CodigoEvento =Convert.ToInt32( txtEvento.Value);
            obj.CodigoUsuario = Convert.ToInt32(txtusuario.Value);
            return obj;
        }
    }


    public class ComentarioModel
    {
        public string Usuario { get; set; }
        public string Mensaje { get; set; }
    }
}