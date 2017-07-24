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
        int fila;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            rpt_todos.DataSource = eve.buscar_aprovados().Tables[0];
            rpt_todos.DataBind();
            
        }


        
        protected void cerrar(object sender, EventArgs e)
        {



            Button btn = sender as Button;

            Label lbl = btn.Parent.FindControl("id") as Label;
            string a = lbl.Text;


            // Response.Redirect("frm_eventos.aspx");

        }

        protected void rpt_todos_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item; // elemento del Repeater

            if (item.ItemType == ListItemType.AlternatingItem || item.ItemType == ListItemType.Item)
            {
                Label idid = (Label)item.FindControl("id"); // obtenemos el control.
                
            }

        }
    }
}