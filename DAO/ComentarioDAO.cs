using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BO;

namespace DAO
{
    public class ComentarioDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO conectar = new conexionDAO();
        public int agregar(object agregar)
        {
            ComentarioBO obejto = (ComentarioBO)agregar;
            SqlCommand cmd = new SqlCommand("INSERT INTO COMENTARIO(COMENTARIO ,EVENTO,USUARIO ) VALUES(@com,@eve,@usu)");
            cmd.Parameters.Add("@com", SqlDbType.VarChar).Value = obejto.Comentario;
            cmd.Parameters.Add("@eve", SqlDbType.Int).Value = obejto.CodigoEvento;
            cmd.Parameters.Add("@usu", SqlDbType.Int).Value = obejto.CodigoUsuario;
            cmd.CommandType = CommandType.Text;

            return conectar.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {
            SqlCommand cmd = new SqlCommand(" select * from  COMENTARIO  ");


            cmd.CommandType = CommandType.Text;


            return conectar.EjecutarSentencia(cmd);
        }

        public int eliminar(object eliminar)
        {
            ComentarioBO obejto = (ComentarioBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete  from COMENTARIO where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;

            cmd.CommandType = CommandType.Text;


            return conectar.EjecutarComando(cmd);
        }

        public int modificar(object modificar)
        {
            ComentarioBO obejto = (ComentarioBO)modificar;
            SqlCommand cmd = new SqlCommand("update  COMENTARIO set COMENTARIO=@com,EVENTO=@eve,USUARIO=@usu where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;
            cmd.Parameters.Add("@com", SqlDbType.VarChar).Value = obejto.Comentario;
            cmd.Parameters.Add("@eve", SqlDbType.Int).Value = obejto.CodigoEvento;
            cmd.Parameters.Add("@usu", SqlDbType.Int).Value = obejto.CodigoUsuario;
            cmd.CommandType = CommandType.Text;
            return conectar.EjecutarComando(cmd);
        }
    }
}
