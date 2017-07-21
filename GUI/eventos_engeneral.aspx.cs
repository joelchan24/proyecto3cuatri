using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

namespace GUI
{
    public partial class eventos_engeneral : System.Web.UI.Page
    {
        eventoDAO eve = new eventoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            rpt_todos.DataSource = eve.buscar_aprovados().Tables[0];
            rpt_todos.DataBind();
        }
    }
}