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
using System.Data.SqlClient;

namespace AdministradorGUI
{
    public partial class Contactos : System.Web.UI.Page
    {
        CTRL_Contactos oCTRL_Contastos = new CTRL_Contactos();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Accion(object sender, EventArgs e)
        {
            Button btnSeleccionado = (Button)sender;
            oCTRL_Contastos.Accion(btnSeleccionado.ID, RecolestarDatos());
            actualizar();

        }

        public ContactosBO RecolestarDatos()
        {
            ContactosBO oContactosBO = new ContactosBO();
            int ID = 0;int.TryParse(txtID.Text, out ID);
            oContactosBO.id_contacto=ID;
            oContactosBO.telefono = txtTelefono.Text;
            return oContactosBO;
        }

        public void actualizar()
        {
            dtgContactos.DataSource = oCTRL_Contastos.listar().Tables[0];
            dtgContactos.DataBind();
        }

        protected void Seleccionar(object sender, DataGridCommandEventArgs e)
        {
           
        }

        protected void dtgContactos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void dtgContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Selecionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                txtID.Text = dtgContactos.Rows[indice].Cells[1].Text;
                txtTelefono.Text = dtgContactos.Rows[indice].Cells[2].Text;

            }
        }

        protected void dtgContactos_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
        }
    }
}