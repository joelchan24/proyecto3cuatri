using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

namespace GUI
{
    public partial class frm_musica : System.Web.UI.Page
    {
        eventoDAO eve = new eventoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            rpt_musica.DataSource = eve.buscar_aprovados_musica().Tables[0];
            rpt_musica.DataBind();
        }
    }
}