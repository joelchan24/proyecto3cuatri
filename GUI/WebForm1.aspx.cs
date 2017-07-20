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
            Repeater1.DataSource = evento.buscar().Tables[0];
            Repeater1.DataBind();
        }
    }
}