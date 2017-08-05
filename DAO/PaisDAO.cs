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
   public class PaisDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO obj = new conexionDAO();
        public int agregar(object agregar)
        {
            PaisBO Pais = (PaisBO)agregar;
            SqlCommand cmd = new SqlCommand("insert into PAIS values (@NOMBRE)");
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Pais.nombre_pais;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {
            throw new NotImplementedException();
        }

        public int eliminar(object eliminar)
        {
            PaisBO Pais = (PaisBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete from PAIS where CODIGO=@CODIGO");
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Pais.id_pais;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet listar()
        {
            SqlCommand cmd = new SqlCommand("select * from PAIS");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);

        }

        public int modificar(object modificar)
        {
            PaisBO Pais = (PaisBO)modificar;
            SqlCommand cmd = new SqlCommand("update PAIS set NOMBRE=@NOMBRE where CODIGO=@CODIGO");
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Pais.nombre_pais;
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Pais.id_pais;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet FILTRAR6(string PARAMETRO6)
        {
            SqlCommand cmd = new SqlCommand("select * from PAIS WHERE NOMBRE LIKE '%"+PARAMETRO6+"%'");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);

        }
    }
}
