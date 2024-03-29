﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;

namespace GUI
{
    public partial class frm_mensajesdelorgaizador : System.Web.UI.Page
    {
        mensajeDAO mensaje = new mensajeDAO();
        public int id;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                 id =Convert.ToInt32( Session["id"]);
                DropDownList1.DataSource = mensaje.usuario(id).Tables[0];
                DropDownList1.DataTextField = "USUARIO";
                DropDownList1.DataValueField = "CODIGO";
                DropDownList1.DataBind();
                refresh();

            }
         
        }
        public void refresh()

        {
            if (!IsPostBack)
            {
                Gridview1.DataSource = mensaje.buscarmensaje(id).Tables[0];
                Gridview1.DataBind();
            }
        }
        public MensajeBO recuperar()
        {
            MensajeBO dato = new MensajeBO();
            int id = 0; int.TryParse(txt_id.Value, out id);
            dato.Codigo = id;
            dato.Cuerpo = txt_mensaje.Text;        
            dato.CodigoUsuario =Convert.ToInt32( Session["id"]);
            dato.Destinatario = DropDownList1.SelectedValue;
            dato.Remitente = Session["usuario"].ToString();
            dato.Status = Convert.ToBoolean(1);
            return dato;




        }

        protected void Gridview1_RowCreated(object sender, GridViewRowEventArgs e)
        {

           e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
        
            e.Row.Cells[6].Visible = false;
            e.Row.Cells[3].Visible = false;
        }

        protected void Gridview1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btn_mensa")
            {
                //foto promocion 7
                //int fila = Convert.ToInt32(e.CommandArgument.ToString());

                int fila = Convert.ToInt32(e.CommandArgument);
                txt_id.Value = Page.Server.HtmlDecode(Gridview1.Rows[fila].Cells[1].Text);
                txt_resivido.Text = Page.Server.HtmlDecode(Gridview1.Rows[fila].Cells[5].Text);
                DropDownList1.SelectedValue = Gridview1.Rows[fila].Cells[6].Text;


            }
        }
        int fila;
        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            //    MensajeBO men = new MensajeBO();
            //  int id = int.Parse(Gridview1.Rows[fila].Cells[1].Text);

            // men.Codigo = id;
            // men.Cuerpo = txt_mensaje.Text;
            //  mensaje.modificarmensajedao(men);
          
            mensaje.agregar(recuperar());
            txt_mensaje.Text = "";
            txt_resivido.Text = "";
            Response.Write("<script>window.alert('mensaje enviado');</script>");
        }

        protected void borra(object sender, EventArgs e)
        {
            txt_resivido.Text = "";
            txt_mensaje.Text = "";
            MensajeBO men = new MensajeBO();
            men.Codigo = Convert.ToInt32(txt_id.Value);
            mensaje.eliminar(men);
         
        }
    }
}