using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;
using Services;
using System.Data.SqlClient;
using System.Data;

namespace AdministradorGUI
{
    public partial class QuienesSomos : System.Web.UI.Page
    {
        CTRL_QuienesSomos oCTRL_QuienesSomos = new CTRL_QuienesSomos();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Accion(object sender, EventArgs e)
        {
            Button btnSeleccionado = (Button)sender;
            oCTRL_QuienesSomos.Accion(btnSeleccionado.ID,RecolectarDAtos());
            actualizar();
        }

        public QuienesSomosBO RecolectarDAtos()
        {
            QuienesSomosBO oQuienesSomosBO = new QuienesSomosBO();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oQuienesSomosBO.id_Quienes = ID;
            oQuienesSomosBO.descripcion = txtDescripcion.Text;
            return oQuienesSomosBO;
        }

        public void actualizar()
        {
            dtgQuienes.DataSource = oCTRL_QuienesSomos.listar().Tables[0];
            dtgQuienes.DataBind();
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                txtID.Text = dtgQuienes.Rows[indice].Cells[1].Text;
                txtDescripcion.Text = dtgQuienes.Rows[indice].Cells[2].Text;

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = RODRIGO\\SQLEXPRESS; Initial catalog = CULTURA; integrated security = true");
            SqlDataAdapter adaptar = new SqlDataAdapter("select * from QUIENESSOMOS where DESCRIPCION like '%" + txtDescripcion.Text + "%'", con);
            SqlDataAdapter ds = new SqlDataAdapter("select * from QUIENESSOMOS where CODIGO like '%" + txtDescripcion.Text + "%'", con);
            DataTable dt = new DataTable();
            adaptar.Fill(dt);
            ds.Fill(dt);
            this.dtgQuienes.DataSource = dt;
            dtgQuienes.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }
    }
}