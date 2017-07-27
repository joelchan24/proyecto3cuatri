using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;
using System.Data;
using System.Web.UI.HtmlControls;
using System.ComponentModel;

namespace GUI
{
    public partial class eventos_engeneral : System.Web.UI.Page
    {
        eventoDAO eve = new eventoDAO();
        conexionDAO conectar = new conexionDAO();
        int fila;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["buscar"] ==null)
            {

                list.DataSource = eve.buscar_aprovados().Tables[0];
                list.DataBind();

            }
            else if (Request.QueryString["buscar"] != null)
                    {
                EventoBO obj = new EventoBO();
                DateTime dato = Convert.ToDateTime(Request.QueryString["buscar"]);
                obj.FechaApertura = dato;
                list.DataSource = eve.buscar_aprovadosdelmater(obj).Tables[0];
                list.DataBind();
            }



            
        }


        
        protected void cerrar(object sender, EventArgs e)
        {
            
             


          //   Response.Redirect("frm_eventos.aspx");

        }

        protected void mandar(object sender, ListViewCommandEventArgs e)
        {
            
        }
    }
}