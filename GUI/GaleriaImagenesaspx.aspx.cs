using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;
using Services;
using System.Security.Cryptography;
using System.Text;

namespace GUI
{
    public partial class GaleriaImagenesaspx : System.Web.UI.Page
    {
        public int id;
        Galeria objgaleria = new Galeria();
        GaleriaBO obboga = new GaleriaBO();
        CTRLGaleria ctrlgaleria = new CTRLGaleria();
        string nombrefoto = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Session["id"].ToString());
            if (!IsPostBack)
            {
                recuperarID();
            }
            datagriew();
        }
        public void recuperarID()
        {
            ddlEventos.DataSource = objgaleria.listarevento(id).Tables[0];
            ddlEventos.DataTextField = "NOMBRE";
            ddlEventos.DataValueField = "CODIGO";
            ddlEventos.DataBind();
        }

        protected void seleccionar(object sender, EventArgs e)
        {
            //buton
            Button selec = (Button)sender;
            if (selec.ID == "btnAgregar")
            {
                if (fileFoto.HasFile)
                {
                    nombrefoto = NombreImagen();
                    fileFoto.SaveAs(Server.MapPath("~/img/") + nombrefoto + ".jpg");
                }
                //FileUploadFoto.Save("miimagen.jpg",ImageFormat.Jpeg);
            }
            ctrlgaleria.accion1(listar(), selec.ID);
            datagriew();

        }
        public string NombreImagen()
        {



            DateTime tiempo = DateTime.Now;
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(tiempo.ToString(System.Globalization.CultureInfo.InvariantCulture)));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();

        } 
        public GaleriaBO listar()
        {
            int id = 0; int.TryParse(txtID.Value, out id);
            obboga.Codigo = id;
            obboga.Foto = nombrefoto;
            obboga.IDEVENTO = Convert.ToInt32(ddlEventos.SelectedValue);
            return obboga;
        }
        public void datagriew()
        {
            dgvGaleria.DataSource = objgaleria.listarimagenes(id).Tables[0];
            dgvGaleria.DataBind();
        }

        protected void esconder(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[3].Visible = false;
        }
    }
}