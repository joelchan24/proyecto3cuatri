﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using Services;
using DAO;

namespace AdministradorGUI
{
    public partial class admin_eventosaprovados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refrecar();
        }



        public void refrecar ()
        {
            eventoDAO evento = new eventoDAO();
            dgv_desaprovados.DataSource = evento.buscar_aprovados().Tables[0];
            dgv_desaprovados.DataBind();
        }

        protected void desaprovar(object sender, GridViewCommandEventArgs e)
        {
            /* if (e.CommandName == "btn_aprovar")
            {
                int fila = Convert.ToInt32(e.CommandArgument.ToString());
                // int indice = Convert.ToInt32(e.CommandArgument);
                int id = int.Parse(dgb_porconfirmar.Rows[fila].Cells[1].Text);

                EventoBO obj = new EventoBO();
                obj.Codigo = id;
                eventado.modificaraprovacion(obj, Convert.ToString(1));
                refrescar();
            }*/
            if (e.CommandName=="btn_desaprovar")
            {
                int fila = Convert.ToInt32(e.CommandArgument.ToString());
                int id = Convert.ToInt32(dgv_desaprovados.Rows[fila].Cells[1].Text);
                EventoBO obj = new EventoBO();
                obj.Codigo = id;
                eventoDAO mandarsobre = new eventoDAO();
                mandarsobre.modificaraprovacion(obj, Convert.ToString(0));
                refrecar();
                    
            }






        }
    }
}