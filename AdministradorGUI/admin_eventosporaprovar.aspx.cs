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
    }
}