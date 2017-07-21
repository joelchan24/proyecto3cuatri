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
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["usuario"] != null)
            {
                txt_usuaer.Text = "welcome " + Session["usuario"].ToString();
            }*/
            if (Session["usuario"] != null && Session["id"] != null)
            {
                txt_usuaer.Text = "welcome " + Session["usuario"].ToString();
             //   Label1.Text = "id es " + Session["id"].ToString();
            }
            else
            {

            }
        }



    }
}