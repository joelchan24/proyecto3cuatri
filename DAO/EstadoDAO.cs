using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BO;

namespace DAO
{
   public class EstadoDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO obj = new conexionDAO();

        public int agregar(object agregar)
        {
            EstadoBO Estados = (EstadoBO)agregar;
            SqlCommand cmd = new SqlCommand("insert into ESTADO values(@NOMBRE,@ID)");
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Estados.nombre_estado;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Estados.id_pais;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {

            SqlCommand cmd = new SqlCommand("select * from ESTADO");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);
        }

        public int eliminar(object eliminar)
        {
            EstadoBO Estados = (EstadoBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete from ESTADO where CODIGO=@CODIGO");
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Estados.id_estado;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public int modificar(object modificar)
        {
            EstadoBO Estados = (EstadoBO)modificar;
            SqlCommand cmd = new SqlCommand("update ESTADO set NOMBRE=@NOMBRE,ID=@ID where CODIGO=@CODIGO");
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Estados.nombre_estado;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Estados.id_pais;
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Estados.id_estado;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet listar()
        {
            SqlCommand cmd = new SqlCommand("select * from ESTADO");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);

        }

        public DataSet Fitrar4(string Parametro4)
        {
            SqlCommand cmd = new SqlCommand("select * from ESTADO where NOMBRE LIKE '%"+Parametro4+"%' ");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);

        }

        public DataSet Buscar_pais()
        {
            SqlCommand cmd = new SqlCommand("select * from PAIS");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);
        }
    }
}
