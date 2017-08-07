using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;

namespace AdministradorGUI
{
    public partial class frm_poraprovar : System.Web.UI.Page
    {
        eventoDAO eventado = new eventoDAO();
        public int val;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                refrescar();
            }
        }
        public void refrescar()
        {

            gri.DataSource = eventado.buscar_noaprovados();
            gri.DataBind();

        }

        protected void gri_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btn_aprovar")
            {
                int fila = Convert.ToInt32(e.CommandArgument.ToString());
                // int indice = Convert.ToInt32(e.CommandArgument);
                int id = int.Parse(gri.Rows[fila].Cells[1].Text);
                int usu = int.Parse(gri.Rows[fila].Cells[14].Text);
                

                EventoBO obj = new EventoBO();
                obj.Codigo = id;
                eventado.modificaraprovacion(obj, Convert.ToString(1));
              /*  MensajesDAO o = new MensajesDAO();
                MensajeBO obje = new MensajeBO();
                int valoree = 0; int.TryParse(txt.Value, out valoree);
                obje.Codigo = valoree;
                obje.Cuerpo = "Evento  ha sido aprobado,Gracias por ser parte de nuestra Página";
                obje.Destinatario = usu.ToString();
                obje.Status = Convert.ToBoolean(1);
                obje.Remitente = Session["usuario"].ToString();
                o.agregar(obje);*/



                refrescar();
               
            }
        }
        public MensajeBO mandar(int usu)
        {
            MensajeBO obje = new MensajeBO();
            int valoree = 0; int.TryParse(txt.Value, out valoree);
            obje.Codigo = valoree;
            obje.Cuerpo = "Evento  ha sido aprobado,Gracias por ser parte de nuestra Página";
            obje.Destinatario = usu.ToString();
            obje.Status = Convert.ToBoolean(1);
            obje.Remitente = Session["usuario"].ToString();
            return obje;
        }

        protected void gri_RowCreated(object sender, GridViewRowEventArgs e)
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