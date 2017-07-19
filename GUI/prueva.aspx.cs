using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class prueva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"]!=null&& Session["id"]!=null)
            {
                txt_usuaer.Text = "welcome " + Session["usuario"].ToString();
                Label1.Text = "id es " + Session["id"].ToString();
            }
        }

        protected void btn_loguat_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("loginn.aspx");
        }
    }
}