using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using Services;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace AdministradorGUI
{
    public partial class admin_eventosaprovados : System.Web.UI.Page
    {
        eventoDAO evento = new eventoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            refrecar();
        }



        public void refrecar ()
        {
           
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            
        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        protected void btnBuscar_Click2(object sender, EventArgs e)
        {
            string valor = txtBuscar.Text;

            dgv_desaprovados.DataSource = evento.buscar_noaprovados123(valor);
            dgv_desaprovados.DataBind();
        
    }

        protected void dgv_desaprovados_RowCreated(object sender, GridViewRowEventArgs e)
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
            e.Row.Cells[28].Visible = false;
            e.Row.Cells[34].Visible = false;
            e.Row.Cells[25].Visible = false;
            e.Row.Cells[26].Visible = false;
        }

        /* protected void btnBuscar_Click(object sender, EventArgs e)
         {
             SqlConnection con = new SqlConnection("Data Source=RODRIGO\\SQLEXPRESS; Initial catalog=CULTURA; integrated security=true");
             SqlDataAdapter adaptar = new SqlDataAdapter("select * from EVENTO where NOMBRE LIKE '%" + txtBuscar.Text + "%'", con);
             DataTable dt = new DataTable();
             adaptar.Fill(dt);
             this.dgv_desaprovados.DataSource = dt;
             dgv_desaprovados.DataBind();
         }*/
    }
}