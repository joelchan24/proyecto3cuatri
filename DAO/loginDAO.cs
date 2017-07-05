using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BO;
namespace DAO
{
 public   class loginDAO
    {
         
        public bool verificar(object agregar)
        {
             usuairoBO  usuario= (usuairoBO)agregar;
            conexionDAO conectar = new conexionDAO();
            SqlCommand cmd = new SqlCommand("select count(usuario) from usuarios where usuario=@usuario and contraseña=@contra");
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.usuario;
            cmd.Parameters.Add("@contra", SqlDbType.VarChar).Value = usuario.Contraseña;
            cmd.CommandType = CommandType.Text;
            int resultado = conectar.EjecutarComando(cmd);

            return (resultado != 0) ? true : false;



        }
    }
}
