using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BO;
using DAO;
using Services;
namespace AdministradorGUI
{
    public partial class admin_eventosporaprovar : System.Web.UI.Page
    {
        ctrol_dirrecionSERVICIOS ser_direccion = new ctrol_dirrecionSERVICIOS();
        ctrol_eventosSERVICIO control = new ctrol_eventosSERVICIO();
        eventoDAO eventado = new eventoDAO();
        direccionDAO obj = new direccionDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        public void refrescar()
        {

            dgb_porconfirmar.DataSource = eventado.buscar_noaprovados();
            dgb_porconfirmar.DataBind();

        }

        protected void eventosporaprovar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btn_aprovar")
            {
                int fila = Convert.ToInt32(e.CommandArgument.ToString());
                // int indice = Convert.ToInt32(e.CommandArgument);
                int id = int.Parse(dgb_porconfirmar.Rows[fila].Cells[1].Text);

                EventoBO obj = new EventoBO();
                obj.Codigo = id;
                eventado.modificaraprovacion(obj, Convert.ToString(1));
                refrescar();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string valor = txtBuscar.Text;

            dgb_porconfirmar.DataSource = eventado.buscar_noaprovados12(valor);
            dgb_porconfirmar.DataBind();
        }

        protected void dgb_porconfirmar_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;
            e.Row.Cells[6].Visible = false;
            e.Row.Cells[7].Visible = false;
            e.Row.Cells[8].Visible = false;
            e.Row.Cells[9].Visible = false;
            e.Row.Cells[10].Visible = false;
            e.Row.Cells[11].Visible = false;
            e.Row.Cells[12].Visible = false;
            e.Row.Cells[11].Visible = false;
            e.Row.Cells[13].Visible = false;
            e.Row.Cells[14].Visible = false;
            e.Row.Cells[15].Visible = false;
            e.Row.Cells[16].Visible = false;
            e.Row.Cells[17].Visible = false;
            e.Row.Cells[18].Visible = false;
            e.Row.Cells[19].Visible = false;
            e.Row.Cells[20].Visible = false;
            e.Row.Cells[21].Visible = false;
            e.Row.Cells[22].Visible = false;
            e.Row.Cells[23].Visible = false;

            e.Row.Cells[31].Visible = false;
            e.Row.Cells[30].Visible = false;
            e.Row.Cells[32].Visible = false;
            e.Row.Cells[27].Visible = false;
        }
    }
}