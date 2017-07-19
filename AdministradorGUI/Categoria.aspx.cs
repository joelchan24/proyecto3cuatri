using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using BO;
using DAO;

namespace AdministradorGUI
{
    public partial class Categoria : System.Web.UI.Page
    {
        CTRL_Categoria oCTRLCategoria = new CTRL_Categoria();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
            
        }

        protected void Accion(object sender, EventArgs e)
        {


            Button btnSelecionado = (Button)sender;
            oCTRLCategoria.Accion(btnSelecionado.ID, RecolectarDAtos());
            actualizar();
        }
        public CategoriaBO RecolectarDAtos()
        {
            CategoriaBO oCategoriaBO = new CategoriaBO();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oCategoriaBO.id_categoria = ID;
            oCategoriaBO.nombre_categoria = txtNombre.Text;         
            return oCategoriaBO;
        }

        public void actualizar()
        {
            dtgCategoria.DataSource = oCTRLCategoria.listar().Tables[0];
            dtgCategoria.DataBind();
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                txtID.Text = dtgCategoria.Rows[indice].Cells[1].Text;
                txtNombre.Text = dtgCategoria.Rows[indice].Cells[2].Text;
               
            }
        }

        protected void txtAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}