using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace GUI
{
    public partial class administrador : System.Web.UI.MasterPage
    {
        eventoDAO eventado = new eventoDAO();
        usuarioDAO objusuario = new usuarioDAO();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TT12AGM\\SQLEXPRESS;Initial Catalog= Personas;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void action(object sender, EventArgs e)
        {
            var btnSeleccionado = (Button)sender;
            if(btnSeleccionado.ID == "btn_eventos")
            {
                DataSet Evento = eventado.buscar();
                DataTable dt = Evento.Tables[0];

                AdministradorGUI.Reportes.ReporteEVentos rpFac = new AdministradorGUI.Reportes.ReporteEVentos();
                rpFac.SetDataSource(dt);

                Session["llena"] = rpFac;

                abreVentana("Reporte.aspx");
            }
            if (btnSeleccionado.ID == "btn_usuarios") //cambiar por btnReporte
            {
                DataSet usuarios = objusuario.LISTARDATOS();
                DataTable dt = usuarios.Tables[0];

                AdministradorGUI.Reportes.ReporteUsuarios rpFac = new AdministradorGUI.Reportes.ReporteUsuarios();
                rpFac.SetDataSource(dt);

                Session["llena"] = rpFac;

                abreVentana("Reporte.aspx");
            }
        }

        private void abreVentana(string ventana)
        {
            Response.Redirect(ventana, true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + "Persona");
            string comando_back = "BACKUP DATABASE [CULTURA] TO  DISK = N'C:\\copia\\"+nombre_copia+"' WITH NOFORMAT, NOINIT,  NAME = N'CULTURA-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
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