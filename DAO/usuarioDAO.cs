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
   public class usuarioDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO obj = new conexionDAO();
        public int agregar(object agregar)
        {
            throw new NotImplementedException();
        }

        public DataSet buscar()
        {
            SqlCommand comando = new SqlCommand("select * from USUARIOS");
            comando.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(comando);
        }

        public int eliminar(object eliminar)
        {
            throw new NotImplementedException();
        }

        public int modificar(object modificar)
        {
            throw new NotImplementedException();
        }
        public bool verificar(object agregar)
        {
            UsuarioBO usuario = (UsuarioBO)agregar;
            conexionDAO conectar = new conexionDAO();
            SqlCommand cmd = new SqlCommand("select count(USUARIO) from USUARIOS where USUARIO=@usuario and CONTRASEÑA=@contra");
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.Usuario;
            cmd.Parameters.Add("@contra", SqlDbType.VarChar).Value = usuario.Contraseña;
            cmd.CommandType = CommandType.Text;
            int resultado = conectar.EjecutarComando(cmd);

            return (resultado != 0) ? true : false;









        }
    }
}
