using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DAO;

namespace GUI
{
    public partial class frm_plus : System.Web.UI.Page
    {
        eventoDAO evento = new eventoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = evento.MAPA().Tables[0];
            Repeater1.DataBind();
        }
    }
}