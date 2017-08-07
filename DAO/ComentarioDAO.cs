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
        public int alterar(object al)
        {
            ComentarioBO obejto = (ComentarioBO)al;
            SqlCommand cmd = new SqlCommand("update  COMENTARIO set COMENTARIO=@com where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;
            cmd.Parameters.Add("@com", SqlDbType.VarChar).Value = obejto.Comentario;
            cmd.CommandType = CommandType.Text;
            return conectar.EjecutarComando(cmd);

        }
        public DataSet listarcomentario(int id)
        {
            SqlCommand cmd = new SqlCommand("select U.FOTOGRAFIA as FOTO,U.USUARIO AS USUARIO,C.COMENTARIO AS COMENTARIO FROM USUARIOS U INNER JOIN COMENTARIO C ON U.CODIGO=C.USUARIO where  C.EVENTO=@ID");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.CommandType = CommandType.Text;
            return conectar.EjecutarSentencia(cmd);
        }
        public DataSet vista()
        {
            SqlCommand cmd = new SqlCommand("select c.*,u.USUARIO,e.NOMBRE from COMENTARIO c inner join USUARIOS u on c.USUARIO=u.CODIGO inner join EVENTO e on c.EVENTO=e.CODIGO");
            cmd.CommandType = CommandType.Text;
            return conectar.EjecutarSentencia(cmd);
        }
        public DataSet buscar(object o)
        {
            ComentarioBO comen = (ComentarioBO)o;
            SqlCommand cmd = new SqlCommand(" select c.*,u.USUARIO,e.NOMBRE from COMENTARIO c inner join USUARIOS u on c.USUARIO=u.CODIGO inner join EVENTO e on c.EVENTO=e.CODIGO where c.COMENTARIO LIKE '%'+@comen+'%'");
            cmd.Parameters.Add("@comen", SqlDbType.VarChar).Value = comen.Comentario;
            cmd.CommandType = CommandType.Text;
            return conectar.EjecutarSentencia(cmd);
        }
    }
}
