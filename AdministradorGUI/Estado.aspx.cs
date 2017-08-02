using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BO;
using DAO;
using Services;

namespace AdministradorGUI
{
    public partial class Estado : System.Web.UI.Page
    {
        CTRL_Estados oCTRLEstados = new CTRL_Estados();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
       

        }

        protected void Accion(object sender, EventArgs e)
        {
            try
            {

                Button btnSelecionado = (Button)sender;
                oCTRLEstados.Accion(btnSelecionado.ID, RecolectarDAtos());
            }
            catch
            {

            }
            actualizar();
        }
        public EstadoBO RecolectarDAtos()
        {
            EstadoBO oEstadosBO = new EstadoBO();
            int ID = 0; int.TryParse(txtID.Text, out ID);
           // int ID_Pais; int.TryParse(tx.Text, out ID_Pais);
            oEstadosBO.id_estado = ID;
            oEstadosBO.nombre_estado = txtNombre.Text;
           // oEstadosBO.id_pais = ID_Pais;
            return oEstadosBO;
        }

        public void actualizar()
        {
            dgv_Estados.DataSource = oCTRLEstados.listar().Tables[0];
            dgv_Estados.DataBind();
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                txtID.Text = dgv_Estados.Rows[indice].Cells[1].Text;
                txtNombre.Text = dgv_Estados.Rows[indice].Cells[2].Text;
                //txt_Pais.Text = dgv_Estados.Rows[indice].Cells[3].Text;
            }
        }

        protected void dgv_Estados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection("Data Source=RODRIGO\\SQLEXPRESS;Initial Catalog= CULTURA;Integrated Security=True");
            SqlDataAdapter adaptar = new SqlDataAdapter("select * from ESTADO where nombre like '%" +txtNombre.Text + "%'", con);
            DataTable dt = new DataTable();
            adaptar.Fill(dt);
            this.dgv_Estados.DataSource = dt;
            dgv_Estados.DataBind();
        }

        protected void seleccionar(object sender, EventArgs e)
        {
            /*Button sele = (Button)sender;
            oCTRLEstados.Accion(sele.ID, RecolectarDAtos());
            actualizar();*/
        }
    }
}