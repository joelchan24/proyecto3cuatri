using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AdministradorGUI
{
    public partial class frm_respaldo : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TT12AGM\\SQLEXPRESS;Initial Catalog= Personas;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }

        protected void seleccionar(object sender, EventArgs e)
        {
            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + "Eventos Culturales");
            string comando_back = "BACKUP DATABASE [CULTURA] TO  DISK = N'C:\\copia\\" + nombre_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'CULTURA-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            SqlCommand cmd = new SqlCommand(comando_back, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script>window.alert('exito');</script>");

            }
            catch (Exception)
            {
                Response.Write("<script>window.alert('fallido');</script>");
            }

            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}