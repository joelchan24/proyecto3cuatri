﻿using System;
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
    public partial class Estado : System.Web.UI.Page
    {
        CTRL_Estados oCTRLEstados = new CTRL_Estados();
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Accion(object sender, EventArgs e)
        {


            Button btnSelecionado = (Button)sender;
            oCTRLEstados.Accion(btnSelecionado.ID, RecolectarDAtos());
            actualizar();
        }
        public EstadoBO RecolectarDAtos()
        {
            EstadoBO oEstadosBO = new EstadoBO();
            int ID = 0; int.TryParse(txt_Id.Text, out ID);
            int ID_Pais; int.TryParse(txt_Pais.Text, out ID_Pais);
            oEstadosBO.id_estado = ID;
            oEstadosBO.nombre_estado = txt_Nombre.Text;
            oEstadosBO.id_pais = ID_Pais;
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
                txt_Id.Text = dgv_Estados.Rows[indice].Cells[1].Text;
                txt_Nombre.Text = dgv_Estados.Rows[indice].Cells[2].Text;
                txt_Pais.Text = dgv_Estados.Rows[indice].Cells[3].Text;
            }
        }

        protected void dgv_Estados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}