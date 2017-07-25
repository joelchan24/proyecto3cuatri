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
   public class LitarTODO
    {
        conexionDAO conex;
        public LitarTODO()
        {
            conex = new conexionDAO();
        }
        public DataSet listarNombre(int id)
        {
            SqlCommand cmd = new SqlCommand("select NOMBRE from USUARIOS WHERE CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = id;
            cmd.CommandType = CommandType.Text;
            return conex.EjecutarSentencia(cmd);

        }
        
    }
}
