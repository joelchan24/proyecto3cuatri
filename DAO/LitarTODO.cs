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
            SqlCommand cmd = new SqlCommand("select US.*,DI.*,MUN.CODIGO,MUN.NOMBRE,CUN.IDTIPO,TIPO.NOMBRE from USUARIOS US INNER JOIN DIRECCION DI ON US.IDDIRECCION=DI.CODIGO INNER JOIN MUNICIPIO MUN ON DI.MUNICIPIO=MUN.CODIGO INNER JOIN TIPOCUENTA_USUARIO CUN ON CUN.IDUSUARIO=US.CODIGO INNER JOIN TIPOCUENTA TIPO ON TIPO.CODIGO=CUN.IDTIPO WHERE US.CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = id;
            cmd.CommandType = CommandType.Text;
            return conex.EjecutarSentencia(cmd);

        }
        
    }
}
