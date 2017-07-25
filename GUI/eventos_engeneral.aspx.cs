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
            
            list.DataSource = eve.buscar_aprovados().Tables[0];
            list.DataBind();
            
        }


        
        protected void cerrar(object sender, EventArgs e)
        {



            Button btn = sender as Button;

            Label lbl = btn.Parent.FindControl("id") as Label;
            Label1.Text = lbl.Text;
 
            


            // Response.Redirect("frm_eventos.aspx");

        }

        protected void mandar(object sender, ListViewCommandEventArgs e)
        {
            
        }
    }
}