using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
   public class Galeria
    {
        conexionDAO conex;
        public Galeria()
        {
            conex = new conexionDAO();
        }
       public DataSet listarevento(int id)
        {
            SqlCommand cmd = new SqlCommand("  SELECT CODIGO,NOMBRE FROM EVENTO WHERE APROVACION=1 AND USUARIO=@COD");
            cmd.Parameters.Add("@COD", SqlDbType.Int).Value = id;
            cmd.CommandType = CommandType.Text;
            return conex.EjecutarSentencia(cmd);

        }
    }
}
