using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;
using Services;
using System.Data;

namespace AdministradorGUI
{
    public partial class Municipios : System.Web.UI.Page
    {
        CTRL_Municipio oCTRLMunicipio = new CTRL_Municipio();
        MunicipioDAO obj = new MunicipioDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
            DropDownList1.DataSource = obj.Buscar_municipio().Tables[0];
            DropDownList1.DataTextField = "NOMBRE";
            DropDownList1.DataValueField = "CODIGO";
            DropDownList1.DataBind();
        }

        protected void Accion(object sender, EventArgs e)
        {


            Button btnSelecionado = (Button)sender;
            //GeneraXML();
            if (btnSelecionado.ID == "btnreporte") //cambiar por btnReporte
            {
                DataSet Pais = obj.listar();
                DataTable dt = Pais.Tables[0];

                Reportes.ReporteMunicipios rpFac = new Reportes.ReporteMunicipios();
                rpFac.SetDataSource(dt);

                Session["llena"] = rpFac;
                Session["Tipo"] = "Municipio";

                abreVentana("Reporte.aspx");
            }
            oCTRLMunicipio.Accion(btnSelecionado.ID, RecolectarDAtos());
            actualizar();
        }
        public MunicipioBO RecolectarDAtos()
        {
            MunicipioBO oMunicipioBO = new MunicipioBO();
            int ID = 0; int.TryParse(txt_IdMunicipio.Text, out ID);
            oMunicipioBO.id_municipio = ID;
            oMunicipioBO.nombre_municipio = txt_NombreMunicipio.Text;
            oMunicipioBO.id_estado = Convert.ToInt32(DropDownList1.SelectedValue);
            return oMunicipioBO;
        }

        public void actualizar()
        {
            dgv_Estados.DataSource = oCTRLMunicipio.listar().Tables[0];
            dgv_Estados.DataBind();
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                txt_IdMunicipio.Text = dgv_Estados.Rows[indice].Cells[1].Text;
                txt_NombreMunicipio.Text = dgv_Estados.Rows[indice].Cells[2].Text;
                DropDownList1.SelectedValue = dgv_Estados.Rows[indice].Cells[3].Text;
            }
        }

        protected void ocultar(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[3].Visible = false;
        }
        private void abreVentana(string ventana)
        {
            Response.Redirect(ventana, true);
        }

        public void GeneraXML()
        {
            //UsuarioBO usuario = new UsuarioBO();


            DataSet Municipio = obj.listar();
            DataTable dt = Municipio.Tables[0];

            dt.WriteXml("Municipio.xml");
        }
    }
}