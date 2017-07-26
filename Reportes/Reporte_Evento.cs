using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
using Reportes.Reportes;


namespace Reportes
{
    public partial class Reporte_Evento : Form
    {
        conexionDAO conex = new conexionDAO();
        public Reporte_Evento()
        {
            InitializeComponent();
        }

        private void Contenedor_Evento_Load(object sender, EventArgs e)
        {

        }

        private void Reporte_Evento_Load(object sender, EventArgs e)
        {
            GenerarReportes();
        }

        public void GenerarReportes()
        {
            ReporteEvento obj_evento = new ReporteEvento();
            string sql = "select * from EVENTO";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conex.establecerConexion());
            DataSet_Evento Ds = new DataSet_Evento();
            adapter.Fill(Ds, "EVENTO");
            obj_evento.SetDataSource(Ds);
            Contenedor_Evento.ReportSource = obj_evento;
        }
    }
}
