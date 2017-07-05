using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using    System.Web.Security;
using BO;
using DAO;


namespace GUI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            usuairoBO obj = new usuairoBO();
            obj.Usuario = txt_nombre.Text;
            obj.Contraseña = txt_contraeña.Text;

            loginDAO usuario = new loginDAO();

            if (usuario.verificar(obj))
            {

                Response.Write("<script>alert('Usuario correcto')</script>");
                FormsAuthentication.SignOut();
                Response.Redirect("WebForm1.aspx");
               

            }
            else
            {
                Response.Write("<script>alert('Usuario correcto')</script>");

            }


        }
    }
}