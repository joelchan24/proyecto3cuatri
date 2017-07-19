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
    public class CategoriaDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO obj = new conexionDAO();
        public int agregar(object agregar)
        {
            CategoriaBO Categoria = (CategoriaBO)agregar;
            SqlCommand cmd = new SqlCommand("insert into CATEGORIA values(@NOMBRE)");
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Categoria.nombre_categoria;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {
            throw new NotImplementedException();
        }

        public int eliminar(object eliminar)
        {
            CategoriaBO Categoria = (CategoriaBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete from CATEGORIA where CODIGO=@CODIGO");
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Categoria.id_categoria;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public int modificar(object modificar)
        {
            CategoriaBO Categoria = (CategoriaBO)modificar;
            SqlCommand cmd = new SqlCommand("update CATEGORIA set NOMBRE=@NOMBRE where CODIGO=@CODIGO");
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Categoria.nombre_categoria;
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Categoria.id_categoria;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet listar()
        {
            SqlCommand cmd = new SqlCommand("select * from CATEGORIA");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);

        }
    }
}
