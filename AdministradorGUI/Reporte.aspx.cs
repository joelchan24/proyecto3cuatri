using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministradorGUI
{
    public partial class Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object obje = (object)Session["llena"];
            llena(obje);
        }

        public void llena(object obj)
        {
            CrystalReportViewer1.ReportSource = obj;
        }
    }
}