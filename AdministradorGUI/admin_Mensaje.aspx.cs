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
    public partial class admin_Mensaje : System.Web.UI.Page
    {
        CTRL_Mensajes oCTRLMensajes = new CTRL_Mensajes();
        bool status;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
            
        }

        protected void Accion_Click(object sender, EventArgs e)
        {

            Button btnSelecionado = (Button)sender;
            oCTRLMensajes.Accion(btnSelecionado.ID, RecolectarDAtos());
            actualizar();
            Limpiar();
        }
        public void actualizar()
        {
            dvg_Mensajes.DataSource = oCTRLMensajes.listar().Tables[0];
            dvg_Mensajes.DataBind();
        }
        public MensajeBO RecolectarDAtos()
        {
            MensajeBO oMensajesBO = new MensajeBO();
            int ID = 0; int.TryParse(txt_ID.Text, out ID);
            //int Codigo = 0; int.TryParse(txt_Usuario.Text, out ID);
            oMensajesBO.Codigo = ID;
            oMensajesBO.Remitente = txt_Remitente.Text;
            oMensajesBO.Destinatario = txt_Destinatario.Text;
            oMensajesBO.Cuerpo = txt_COmentario.Text;
            oMensajesBO.Status = true;
            oMensajesBO.CodigoEvento = int.Parse(txt_Evento.Text);
            oMensajesBO.CodigoUsuario = int.Parse(txt_Usuario.Text);

            return oMensajesBO;
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
           
            //if (e.CommandName == "dgvbtnSeleccionar")
            //{
                int indice = Convert.ToInt32(e.CommandArgument);
                txt_ID.Text = dvg_Mensajes.Rows[indice].Cells[1].Text;
                status = true;
                txt_Destinatario.Text = dvg_Mensajes.Rows[indice].Cells[3].Text;
                txt_Remitente.Text = dvg_Mensajes.Rows[indice].Cells[4].Text;
                txt_COmentario.Text = dvg_Mensajes.Rows[indice].Cells[5].Text;

                txt_Usuario.Text = dvg_Mensajes.Rows[indice].Cells[6].Text;
                txt_Evento.Text = dvg_Mensajes.Rows[indice].Cells[7].Text;
               
               
                //txt_status.Text = dvg_Mensajes.Rows[indice].Cells[6].Text;
                
            //}
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            
        }

        public void Limpiar()
        {
            txt_Usuario.Text = "";
            txt_Remitente.Text = "";
            txt_ID.Text = "";
            txt_Evento.Text = "";
            txt_Destinatario.Text = "";
            txt_COmentario.Text = "";
        }
    }
}