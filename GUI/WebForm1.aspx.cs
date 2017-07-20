using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;
using Services;

namespace GUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        eventoDAO evento = new eventoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
           Repeater1.DataSource = evento.buscar_aprovados().Tables[0];
           Repeater1.DataBind();
            //aqui el maximo resgiutro
            rpt_uno.DataSource = evento.busca1().Tables[0];
            rpt_uno.DataBind();
            //aqui el maximo resgiutro
            rtp_dos.DataSource = evento.busca2().Tables[0];
            rtp_dos.DataBind();
            //aqui el maximo resgiutro
            rtb_3.DataSource = evento.busca3().Tables[0];
            rtb_3.DataBind();
        }
    }
}