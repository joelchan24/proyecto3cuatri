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
    public class MunicipioDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO obj = new conexionDAO();
        public int agregar(object agregar)
        {
            MunicipioBO Municipio = (MunicipioBO)agregar;
            SqlCommand cmd = new SqlCommand("insert into MUNICIPIO values (@NOMBRE,@ID)");
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Municipio.nombre_municipio;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Municipio.id_estado;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {
            throw new NotImplementedException();
        }

        public int eliminar(object eliminar)
        {
            MunicipioBO Municipio = (MunicipioBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete from MUNICIPIO where CODIGO=@CODIGO");
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Municipio.id_municipio;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public int modificar(object modificar)
        {
            MunicipioBO Municipio = (MunicipioBO)modificar;
            SqlCommand cmd = new SqlCommand("update MUNICIPIO set NOMBRE=@NOMBRE,ID=@ID where CODIGO=@CODIGO");
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Municipio.nombre_municipio;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Municipio.id_estado;
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Municipio.id_municipio;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet listar()
        {
            SqlCommand cmd = new SqlCommand("select * from MUNICIPIO");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);

        }
    }
}
