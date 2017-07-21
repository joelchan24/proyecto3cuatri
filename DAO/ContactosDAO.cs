using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ContactosDAO
    {
        conexionDAO obj = new conexionDAO();

        public int agregar(object agregar)
        {
            ContactosBO Contactos = (ContactosBO)agregar;
            SqlCommand cmd = new SqlCommand("insert into CONTACTOS values (@TELEFONO)");
            cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = Contactos.telefono;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {
            SqlCommand cmd = new SqlCommand("select * from CONTACTOS where TELEFONO ");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);
            
        }

        public int eliminar(object eliminar)
        {
            ContactosBO Contactos = (ContactosBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete from CONTACTOS where CODIGO=@CODIGO");
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = Contactos.id_contacto;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public int modificar(object modificar)
        {
            ContactosBO Contactos = (ContactosBO)modificar;
            SqlCommand cmd = new SqlCommand("update CONTACTOS set TELEFONO=@tel where CODIGO=@cod");
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = Contactos.telefono;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = Contactos.id_contacto;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet listar()
        {
            SqlCommand cmd = new SqlCommand("select * from CONTACTOS");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);
        }
    }
}
