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
            UsuarioBO objdire = (UsuarioBO)agregar;
            SqlCommand id = new SqlCommand("INSERT INTO DIRECCION(COLONIA,CODIGOPOSTAL,CRUZAMIENTO,NUMEROINTERIOR,NUMEROEXTERIOR,MUNICIPIO) OUTPUT INSERTED.CODIGO VALUES"
                + "(@COLO,@POSTAL,@CRU,@INTE,@EXTE,@MUNI)");
            id.Parameters.Add("@COLO", SqlDbType.VarChar).Value = objdire.Colonia;
            id.Parameters.Add("@POSTAL", SqlDbType.Char).Value = objdire.CodigoPostal;
            id.Parameters.Add("@CRU", SqlDbType.VarChar).Value = objdire.Cruzamiento;
            id.Parameters.Add("@INTE", SqlDbType.VarChar).Value = objdire.NumeroInterior;
            id.Parameters.Add("@EXTE", SqlDbType.VarChar).Value = objdire.NumeroExterior;
            id.Parameters.Add("@MUNI", SqlDbType.Int).Value = objdire.CodigoMunicipio;
            id.CommandType = CommandType.Text;
            SqlCommand cmd = new SqlCommand("insert into USUARIOS(NOMBRE,APELLIDOS,TELEFONO,FECHANACIMIENTO,CORREO,USUARIO,CONTRASEÑA,FOTOGRAFIA,IDDIRECCION)OUTPUT INSERTED.CODIGO VALUES"
                +"(@NOM,@APE,@TELE,@FECHA,@CORREO,@USU,@CONTRA,@FOTO,@DIRECCION)");
            cmd.Parameters.Add("@NOM", SqlDbType.VarChar).Value = objdire.Nombre;
            cmd.Parameters.Add("APE", SqlDbType.VarChar).Value = objdire.Apellidos;
            cmd.Parameters.Add("@TELE", SqlDbType.Char).Value = objdire.Telefono;
            cmd.Parameters.Add("@FECHA", SqlDbType.DateTime).Value = objdire.FechaNacimineto.ToString("YYYY/MM/DD");
            cmd.Parameters.Add("@CORREO", SqlDbType.VarChar).Value = objdire.Correo;
            cmd.Parameters.Add("@USU", SqlDbType.VarChar).Value = objdire.Usuario;
            cmd.Parameters.Add("@CONTRA", SqlDbType.VarChar).Value = objdire.Contraseña;
            cmd.Parameters.Add("@FOTO", SqlDbType.VarChar).Value = objdire.Fotografia;
            cmd.Parameters.Add("@DIRECCION", SqlDbType.Int).Value = id;
            cmd.CommandType = CommandType.Text;
            SqlCommand CUENTA = new SqlCommand("INSERT INTO TIPOCUENTA_USUARIO(IDTIPO,IDUSUARIO)VALUES(@TIPO,@USUARIO)");
            CUENTA.Parameters.Add("@TIPO", SqlDbType.Int).Value = objdire.IDCUENTA;
            CUENTA.Parameters.Add("@USUARIO", SqlDbType.Int).Value = cmd;
            CUENTA.CommandType = CommandType.Text;
            return obj.EjecutarComando(CUENTA);

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
        public DataSet listarusuario()
        {
            SqlCommand cmd = new SqlCommand("select * from TIPOCUENTA WHERE CODIGO!='"+3+"'");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);
        }
        public DataSet listarMunicipio()
        {
            SqlCommand cmd = new SqlCommand("select CODIGO,NOMBRE from MUNICIPIO");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);
        }
    }
}
