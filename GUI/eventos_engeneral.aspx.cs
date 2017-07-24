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


             DataRow row = eve.buscar_aprovados().Tables[0].Rows[fila];
                int val = Convert.ToInt32(row[0].ToString());


            //   EventoBO obj = new EventoBO();*/
            //   foreach( i As RepeaterItem In rp .Items)
            // string id= ((Label)  rpt_todos.Items[1].FindControl("id")).Text;
            //   ImageButton imgBtnEliminar = (ImageButton)rptitems.FindControl("imgBtnEliminar"); // obtenemos el control.
            //  Repeater tableR = (Repeater)this.Page.Master.FindControl("tablaR");
            //  Label milabel = new Label();
            //Label lblRut =ctype (Label)rpt_todos.Items[1].FindControl("id");
            //Label1.Text=
            //  milabe
            // Label1.Text = lblRut.Text;



            //string t =Convert.ToString( (Label)rpt_todos.Items[1].FindControl("id"));
            // string id = t.ToString();
            // 
            Label1.Text = val.ToString();


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