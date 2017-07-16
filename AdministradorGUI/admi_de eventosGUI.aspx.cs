using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BO;
using DAO;

namespace AdministradorGUI
{
    public partial class admi_de_eventosGUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        protected void txt_codir_ValueChanged(object sender, EventArgs e)
        {

        }
      
        public EventoBO devolver()
        {
            EventoBO obj = new EventoBO();

            int id = 0; int.TryParse(txtid.Value, out id);
            int iddir = 0;int.TryParse(txt_codir.Value, out iddir);
            obj.Codigo = id;
            obj.Descripcion =txt_descrip.Text;
            obj.Nombre = txt_nombre.Text;
            obj.costo = Convert.ToInt32(txt_precio.Text);
            obj.FechaApertura =Convert.ToDateTime(txt_aperura.Text);
            obj.FechaCierre = Convert.ToDateTime(txt_fecha_cierre.Text);
            obj.FotoPromocion = file_foto.ToString();
            obj.UbicacionGeografica = txt_ubicar.Text;
            obj.longitud = txt_lo.Text;
            obj.latitud = txtlat.Text;
            obj.CodigoDireccion = Convert.ToInt32(iddir.ToString());
            obj.CodigoCategoria = Convert.ToInt32(ddl_categoria.SelectedValue);
            obj.CodigoUsuario =Convert.ToInt32( txt_usuario.Text);
            return obj;



        }
        public Direccion mandar()
        {
            Direccion dir = new Direccion();

           
            int iddir = 0; int.TryParse(txt_codir.Value, out iddir);
            dir.Codigo = iddir;
            dir.Colonia = txt_colonia.Text;
            dir.CodigoPostal = txt_postal.Text;
            dir.Cruzamiento = txt_crizamiento.Text;
            dir.NumeroExterior = txt_numexter.Text;
            dir.NumeroInterior = txt_numint.Text;
            dir.CodigoMunicipio = Convert.ToInt32(ddl_municipio.SelectedValue);
           
         
            return dir;



        }

    }
}