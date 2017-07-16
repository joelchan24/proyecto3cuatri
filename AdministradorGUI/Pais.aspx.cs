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
    public partial class Pais : System.Web.UI.Page
    {
        CTRL_Pais oCTRLPais = new CTRL_Pais();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Accion(object sender, EventArgs e)
        {


            Button btnSelecionado = (Button)sender;
            oCTRLPais.Accion(btnSelecionado.ID, RecolectarDAtos());
            actualizar();
        }
        public PaisBO RecolectarDAtos()
        {
            PaisBO oPaisBO = new PaisBO();
            int ID = 0; int.TryParse(txt_IdPais.Text, out ID);
            oPaisBO.id_pais = ID;
            oPaisBO.nombre_pais = txt_NombrePais.Text;
            return oPaisBO;
        }

        public void actualizar()
        {
            dgv_Pais.DataSource = oCTRLPais.listar().Tables[0];
            dgv_Pais.DataBind();
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                txt_IdPais.Text = dgv_Pais.Rows[indice].Cells[1].Text;
                txt_NombrePais.Text = dgv_Pais.Rows[indice].Cells[2].Text;
                
            }
        }
    }
}