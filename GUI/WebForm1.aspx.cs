using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;
using Services;
using System.Collections;

namespace GUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        eventoDAO evento = new eventoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
          

            Repeater1.DataSource = evento.top_3visitas().Tables[0];
           Repeater1.DataBind();
            //aqui el maximo resgiutro
            rpt_uno.DataSource = evento.top_3recientes().Tables[0];
            rpt_uno.DataBind();

        }

        protected void mandar(object sender, EventArgs e)
        {
            Response.Redirect("eventos_engeneral.aspx");
        }
    }
}