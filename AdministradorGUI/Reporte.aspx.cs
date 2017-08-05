using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;
using System.Data;

namespace AdministradorGUI
{
    public partial class Reporte : System.Web.UI.Page
    {
        usuarioDAO objusuario = new usuarioDAO();
        eventoDAO eve = new eventoDAO();
        CategoriaDAO cat = new CategoriaDAO();
        EstadoDAO est = new EstadoDAO();
        MunicipioDAO mun = new MunicipioDAO();
        PaisDAO pa = new PaisDAO();


        protected void Page_Load(object sender, EventArgs e)
        {
            object obje = (object)Session["llena"];
            llena(obje);
        }

        public void llena(object obj)
        {
            CrystalReportViewer1.ReportSource = obj;
        }

        protected void Accion(object sender, EventArgs e)
        {
            DateTime Fecha;
            string tipo = (string)Session["Tipo"];
            if (string.IsNullOrEmpty(txtfecha.Text))
            {

                Fecha = DateTime.Now;
            }
            else
            {
                Fecha = DateTime.Parse(txtfecha.Text);
            }
            if (tipo == "Usuario")
            {
                DataSet usuarios = objusuario.Filtar(txtbuscar.Text, Fecha);
                DataTable dt = usuarios.Tables[0];

                Reportes.ReporteUsuarios rpFac = new Reportes.ReporteUsuarios();
                rpFac.SetDataSource(dt);

                Session["llena"] = rpFac;
            }
            if(tipo=="Categoria")
            {
                DataSet Categoria = cat.FILTRAR3(txtbuscar.Text);
                DataTable dt = Categoria.Tables[0];

                Reportes.ReporteCategoria rpFac = new Reportes.ReporteCategoria();
                rpFac.SetDataSource(dt);


                Session["llena"] = rpFac;
            }
            if(tipo=="Pais")
            {
                DataSet Pais = pa.FILTRAR6(txtbuscar.Text);
                DataTable dt = Pais.Tables[0];

                Reportes.ReportePaises rpFac = new Reportes.ReportePaises();
                rpFac.SetDataSource(dt);

                Session["llena"] = rpFac;
            }
            if(tipo=="Municipio")
            {
                DataSet Pais = mun.FILTRAR5(txtbuscar.Text);
                DataTable dt = Pais.Tables[0];

                Reportes.ReporteMunicipios rpFac = new Reportes.ReporteMunicipios();
                rpFac.SetDataSource(dt);

                Session["llena"] = rpFac;
            }
            if(tipo=="Estado")
            {
                DataSet Estado = est.Fitrar4(txtbuscar.Text);
                DataTable dt = Estado.Tables[0];

                Reportes.ReporteEstados rpFac = new Reportes.ReporteEstados();
                rpFac.SetDataSource(dt);

                Session["llena"] = rpFac;
            }
            if (tipo=="Evento")
            {
                DataSet Evento = eve.FILTRAR2(txtbuscar.Text,Fecha);
                DataTable dt = Evento.Tables[0];

                Reportes.ReporteEVentos rpFac = new Reportes.ReporteEVentos();
                rpFac.SetDataSource(dt);

                Session["llena"] = rpFac;
            }

            abreVentana("Reporte.aspx");
            
        }
        private void abreVentana(string ventana)
        {
            try
            {
                Response.Redirect(ventana, true);
            }
            catch { }
        }
    }
}