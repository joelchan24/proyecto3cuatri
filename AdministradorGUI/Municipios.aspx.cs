using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;
using Services;

namespace AdministradorGUI
{
    public partial class Municipios : System.Web.UI.Page
    {
        CTRL_Municipio oCTRLMunicipio = new CTRL_Municipio();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Accion(object sender, EventArgs e)
        {


            Button btnSelecionado = (Button)sender;
            oCTRLMunicipio.Accion(btnSelecionado.ID, RecolectarDAtos());
            actualizar();
        }
        public MunicipioBO RecolectarDAtos()
        {
            MunicipioBO oMunicipioBO = new MunicipioBO();
            int ID = 0; int.TryParse(txt_IdMunicipio.Text, out ID);
            int ID_Estado; int.TryParse(txt_Estado.Text, out ID_Estado);
            oMunicipioBO.id_municipio = ID;
            oMunicipioBO.nombre_municipio = txt_NombreMunicipio.Text;
            oMunicipioBO.id_estado = ID_Estado;
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
                txt_Estado.Text = dgv_Estados.Rows[indice].Cells[3].Text;
            }
        }
    }
}