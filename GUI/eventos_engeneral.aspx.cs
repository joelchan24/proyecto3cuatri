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
        conexionDAO conectar = new conexionDAO();
        int fila;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            list.DataSource = eve.buscar_aprovados().Tables[0];
            list.DataBind();
            
        }


        
        protected void cerrar(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(list.SelectedValue);

            DataRow row = eve.buscar_aprovados().Tables[0].Rows[fila];
            int val = Convert.ToInt32(row[0].ToString());



            Button btn = sender as Button;

            Label lbl = btn.Parent.FindControl("id") as Label;
            Label1.Text = id.ToString();
             


          //   Response.Redirect("frm_eventos.aspx");

        }

        protected void mandar(object sender, ListViewCommandEventArgs e)
        {
            
        }
    }
}