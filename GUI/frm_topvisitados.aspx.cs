using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

namespace GUI
{
    public partial class frm_topvisitados : System.Web.UI.Page
    {
        eventoDAO obj = new eventoDAO(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            ListView1.DataSource = obj.top_recientes().Tables[0];
            ListView1.DataBind();
        }
    }
}