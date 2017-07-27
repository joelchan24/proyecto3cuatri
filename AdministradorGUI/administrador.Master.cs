using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class administrador : System.Web.UI.MasterPage
    {
        eventoDAO eventado = new eventoDAO();
        usuarioDAO objusuario = new usuarioDAO();

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
    }
}