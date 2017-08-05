using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using BO;
using DAO;
using System.Data;

namespace AdministradorGUI
{
    public partial class Categoria : System.Web.UI.Page
    {
        CTRL_Categoria oCTRLCategoria = new CTRL_Categoria();
        CategoriaDAO obj = new CategoriaDAO();
        CategoriaBO c = new CategoriaBO();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
            
        }

        protected void Accion(object sender, EventArgs e)
        {
           // GeneraXML();
            Button btnSelecionado = (Button)sender;
            if (btnSelecionado.ID == "btnBuscar") //cambiar por btnReporte
            {
                DataSet Categoria = obj.listar();
                DataTable dt = Categoria.Tables[0];

                Reportes.ReporteCategoria rpFac = new Reportes.ReporteCategoria();
                rpFac.SetDataSource(dt);


                Session["llena"] = rpFac;
                Session["Tipo"] = "Categoria";

                abreVentana("Reporte.aspx");
            }

            //Button btnSelecionado = (Button)sender;
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

        private void abreVentana(string ventana)
        {
            Response.Redirect(ventana, true);
        }

        public void GeneraXML()
        {
            //UsuarioBO usuario = new UsuarioBO();


            DataSet Categoria = obj.listar();
            DataTable dt = Categoria.Tables[0];

            dt.WriteXml("categoria.xml");
        }
    }
}