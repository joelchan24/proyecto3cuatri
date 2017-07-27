using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class home : System.Web.UI.MasterPage
    {
        string tipo;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                
            /*if (Session["usuario"] != null)
            {
                txt_usuaer.Text = "welcome " + Session["usuario"].ToString();
            }*/
            /*  if (Session["usuario"] !=null && Session["id"] != null)
              {
                  txt_usuaer.Text = "welcome " + Session["usuario"].ToString();
               //   Label1.Text = "id es " + Session["id"].ToString();
              }
              else
              {

              }*/
        }

        protected void btn_loguat_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("loginn.aspx");
        }

        protected void cerrar(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("loggin_fuerademasterpage.aspx");
        }

        protected void mandar(object sender, EventArgs e)
        {
            //  Response.Redirect("WebForm1.aspx?accion=" + txtlat.Text.Trim());
            Response.Redirect("eventos_engeneral.aspx?buscar=" + Convert.ToDateTime(txt_buscar.Text));
        }
    }
}