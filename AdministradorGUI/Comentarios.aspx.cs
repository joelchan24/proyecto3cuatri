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
    public partial class Comentarios : System.Web.UI.Page
    {
        ComentarioDAO comen = new ComentarioDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            listar();

        }
        public void listar()
        {
            ComentarioDAO cmd = new ComentarioDAO();
            dgbDatos.DataSource = cmd.vista().Tables[0];
            dgbDatos.DataBind();
        }

        protected void selecionar(object sender, GridViewCommandEventArgs e)
        {
            int sele = Convert.ToInt32(e.CommandArgument.ToString());
            TextBox1.Text = dgbDatos.Rows[sele].Cells[5].Text;
            TextBox2.Text = dgbDatos.Rows[sele].Cells[6].Text;
            txtComentario.Text = dgbDatos.Rows[sele].Cells[2].Text;
            txtIDcomentario.Value = dgbDatos.Rows[sele].Cells[1].Text;
            txtUsuarioID.Value = dgbDatos.Rows[sele].Cells[3].Text;
            txtEventoID.Value = dgbDatos.Rows[sele].Cells[4].Text;
        }
        public ComentarioBO vista()
        {
            ComentarioBO comen = new ComentarioBO();
            int id = 0; int.TryParse(txtIDcomentario.Value, out id);
            comen.Codigo = id;
            comen.Comentario = txtComentario.Text;
            return comen;
        }

        protected void seleccionar(object sender, EventArgs e)
        {
            try
            {


                Button selecionado = (Button)sender;
                ComentarioDAO comen2 = new ComentarioDAO();
                switch (selecionado.ID)
                {
                    case "btnBuscar":
                        dgbDatos.DataSource = comen2.buscar(vista()).Tables[0];
                        dgbDatos.DataBind();
                        break;
                    case "btnLimpiar":
                        Limpiar();
                        break;
                }
                Button sele = (Button)sender;
                CTRLComentario comen = new CTRLComentario();
                comen.Comentario(vista(), sele.ID);
                Limpiar();
            }
            catch
            {

            }
        }
        public void Limpiar()
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
            txtComentario.Text = null;
            txtEventoID.Value = null;
            txtUsuarioID.Value = null;
            txtIDcomentario.Value = null;
        }
    }
}