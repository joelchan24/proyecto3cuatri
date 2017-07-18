using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    class conexionDAO
    {
        SqlCommand comandosql;
        SqlDataAdapter adaptador;
        DataSet datasetadaptador;
        SqlConnection coneccion;


        public conexionDAO()
        {
            adaptador = new SqlDataAdapter();
            comandosql = new SqlCommand();
            coneccion = new SqlConnection();



        }

        public SqlConnection establecerConexion()
        {
            string cs = "Data Source=YEKO-PC\\SQLEXPRESS; Initial catalog=CULTURA; integrated security=true";
            coneccion = new SqlConnection(cs);
            return coneccion;
        }


        public void abrirConexion()
        {
            coneccion.Open();
        }
        public void cerrarConexion()
        {
            coneccion.Close();
        }
        public DataSet EjecutarSentencia(SqlCommand SqlComando)
        {

            // SELECT (Devolver registros)
            adaptador = new SqlDataAdapter();
            comandosql = new SqlCommand();
            datasetadaptador = new DataSet();

            comandosql = SqlComando;
            comandosql.Connection = this.establecerConexion();
            this.abrirConexion();
            adaptador.SelectCommand = comandosql;
            adaptador.Fill(datasetadaptador);
            this.cerrarConexion();
            return datasetadaptador;

        }
        public int EjecutarComando(SqlCommand SqlComando)
        {
            // INSERT, DELETE, UPDATE
            comandosql = new SqlCommand();
            comandosql = SqlComando;
            comandosql.Connection = this.establecerConexion();
            this.abrirConexion();
            int id = 0; id = Convert.ToInt32(comandosql.ExecuteScalar());
            this.cerrarConexion();
            return id;

        }

        //nota joel .yo agregar estas clases de conexionews por que me serviran ustedes usen la de arirba 
        //posatata puto jesus
        public int ejecutarComandostring(string comando)
        {
            // string strcomandoSQL = comando;
            comandosql.Connection = this.establecerConexion();
            this.abrirConexion();
            comandosql.CommandText = comando;

            int id = 0; id = (Convert.ToInt32(comandosql.ExecuteScalar()) != 0) ? Convert.ToInt32(comandosql.ExecuteScalar()) : 0;


            this.cerrarConexion();

            return id;
        }

        public DataSet ejecutarsentenciastring(string sentencia)
        {
            //metodo para utilizar select's
            datasetadaptador = new DataSet();
            comandosql.CommandText = sentencia;

            comandosql.Connection = this.establecerConexion();
            this.abrirConexion();
            adaptador.SelectCommand = comandosql;
            adaptador.Fill(datasetadaptador);

            return datasetadaptador;
        }









    }
}
