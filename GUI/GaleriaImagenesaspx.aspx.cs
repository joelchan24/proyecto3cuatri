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
    public partial class GaleriaImagenesaspx : System.Web.UI.Page
    {
        public int id;
        Galeria objgaleria = new Galeria();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                recuperarID();
            }
           
        }
        public void recuperarID()
        {
            txtID.Value = Session["id"].ToString();
            id = int.Parse(txtID.Value);
            ddlEventos.DataSource = objgaleria.listarevento(id).Tables[0];
            ddlEventos.DataTextField = "NOMBRE";
            ddlEventos.DataValueField = "CODIGO";
            ddlEventos.DataBind();
        }
    }
}