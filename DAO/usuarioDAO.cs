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
            int ID = obj.EjecutarComando(id);
            SqlCommand cmd = new SqlCommand("insert into USUARIOS(NOMBRE,APELLIDOS,TELEFONO,FECHANACIMIENTO,CORRERO,USUARIO,CONTRASEÑA,FOTOGRAFIA,IDDIRECCION)OUTPUT INSERTED.CODIGO VALUES"
                +"(@NOM,@APE,@TELE,@FECHA,@CORREO,@USU,@CONTRA,@FOTO,'"+ID+"')");
            cmd.Parameters.Add("@NOM", SqlDbType.VarChar).Value = objdire.Nombre;
            cmd.Parameters.Add("@APE", SqlDbType.VarChar).Value = objdire.Apellidos;
            cmd.Parameters.Add("@TELE", SqlDbType.Char).Value = objdire.Telefono;
            cmd.Parameters.Add("@FECHA", SqlDbType.Date).Value = objdire.FechaNacimineto;
            cmd.Parameters.Add("@CORREO", SqlDbType.VarChar).Value = objdire.Correo;
            cmd.Parameters.Add("@USU", SqlDbType.VarChar).Value = objdire.Usuario;
            cmd.Parameters.Add("@CONTRA", SqlDbType.VarChar).Value = objdire.Contraseña;
            cmd.Parameters.Add("@FOTO", SqlDbType.VarChar).Value = objdire.Fotografia;
            int Cuenta = obj.EjecutarComando(cmd);
            SqlCommand CUENTA = new SqlCommand("INSERT INTO TIPOCUENTA_USUARIO(IDTIPO,IDUSUARIO)VALUES(@TIPO,'"+Cuenta+"')");
            CUENTA.Parameters.Add("@TIPO", SqlDbType.Int).Value = objdire.IDCUENTA;
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
            UsuarioBO obj3 = (UsuarioBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete from TIPOCUENTA_USUARIO WHERE IDUSUARIO=@ID");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = obj3.Codigo;
            cmd.CommandType = CommandType.Text;
            int usu = obj.EjecutarComando(cmd);

            SqlCommand galeria = new SqlCommand("delete from GALERIA WHERE IDEVENTO=(SELECT CODIGO FROM EVENTO WHERE USUARIO=@USU)");
            galeria.Parameters.Add("@USU", SqlDbType.Int).Value = obj3.Codigo;
            galeria.CommandType = CommandType.Text;
            int gal = obj.EjecutarComando(galeria);

            SqlCommand hora = new SqlCommand("delete from HORARIOS where EVENTO=(SELECT CODIGO FROM EVENTO WHERE USUARIO=@HO)");
            hora.Parameters.Add("@HO", SqlDbType.Int).Value = obj3.Codigo;
            hora.CommandType = CommandType.Text;
            int hori = obj.EjecutarComando(hora);

            SqlCommand evento = new SqlCommand("delete from EVENTO WHERE USUARIO=@EVE");
            evento.Parameters.Add("@EVE", SqlDbType.Int).Value = obj3.Codigo;
            evento.CommandType = CommandType.Text;
            int elini = obj.EjecutarComando(evento);

            SqlCommand direccion = new SqlCommand("delete from USUARIOS WHERE CODIGO=@COD");
            direccion.Parameters.Add("@COD", SqlDbType.Int).Value = obj3.Codigo;
            direccion.CommandType = CommandType.Text;
            int USUARIO = obj.EjecutarComando(direccion);


            int repuesta = ((usu != 0) && (gal != 0) && (hori!=0) && (elini!=0) && (USUARIO!=0)) ? 1 : 0;
            return repuesta;

        }

        public int modificar(object modificar)
        {
            UsuarioBO OBJJUSUARIO = (UsuarioBO)modificar;
            SqlCommand cmd = new SqlCommand("update DIRECCION SET COLONIA=@COL,CODIGOPOSTAL=@CODP,CRUZAMIENTO=@CRUZA,NUMEROINTERIOR=@INTE,NUMEROEXTERIOR=@EXTE,MUNICIPIO=@MUNI WHERE CODIGO=(SELECT IDDIRECCION FROM USUARIOS WHERE CODIGO=@USU) ");
            cmd.Parameters.Add("@COL", SqlDbType.VarChar).Value = OBJJUSUARIO.Colonia;
            cmd.Parameters.Add("CODP", SqlDbType.Char).Value = OBJJUSUARIO.CodigoPostal;
            cmd.Parameters.Add("@CRUZA", SqlDbType.VarChar).Value = OBJJUSUARIO.Cruzamiento;
            cmd.Parameters.Add("INTE", SqlDbType.VarChar).Value = OBJJUSUARIO.NumeroInterior;
            cmd.Parameters.Add("@EXTE", SqlDbType.VarChar).Value = OBJJUSUARIO.NumeroExterior;
            cmd.Parameters.Add("@MUNI", SqlDbType.Int).Value = OBJJUSUARIO.CodigoMunicipio;
            cmd.Parameters.Add("@USU", SqlDbType.Int).Value = OBJJUSUARIO.Codigo;
            cmd.CommandType = CommandType.Text;
            int direccion = obj.EjecutarComando(cmd);

            SqlCommand usuario = new SqlCommand("update USUARIOS SET NOMBRE=@NO,APELLIDOS=@APE,TELEFONO=@TELE,FECHANACIMIENTO=@FECH,CORRERO=@COR,USUARIO=@USUARIO,CONTRASEÑA=@CON,FOTOGRAFIA=@FOTO WHERE CODIGO=@COD");
            usuario.Parameters.Add("@NO", SqlDbType.VarChar).Value = OBJJUSUARIO.Nombre;
            usuario.Parameters.Add("@APE", SqlDbType.VarChar).Value = OBJJUSUARIO.Apellidos;
            usuario.Parameters.Add("@TELE", SqlDbType.Char).Value = OBJJUSUARIO.Telefono;
            usuario.Parameters.Add("@FECH", SqlDbType.Date).Value = OBJJUSUARIO.FechaNacimineto;
            usuario.Parameters.Add("@COR", SqlDbType.VarChar).Value = OBJJUSUARIO.Correo;
            usuario.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = OBJJUSUARIO.Usuario;
            usuario.Parameters.Add("@CON", SqlDbType.VarChar).Value = OBJJUSUARIO.Contraseña;
            usuario.Parameters.Add("@FOTO", SqlDbType.VarChar).Value = OBJJUSUARIO.Fotografia;
            usuario.Parameters.Add("@COD", SqlDbType.Int).Value = OBJJUSUARIO.Codigo;
            usuario.CommandType = CommandType.Text;

            return obj.EjecutarComando(usuario);
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
        public DataSet LISTARDATOS()
        {
            SqlCommand CMD = new SqlCommand("select h.*,d.*,f.* from USUARIOS H, DIRECCION D, MUNICIPIO F WHERE H.IDDIRECCION=D.CODIGO AND F.CODIGO=(SELECT MUNICIPIO FROM DIRECCION WHERE CODIGO=(SELECT IDDIRECCION FROM USUARIOS))");
            CMD.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(CMD);
        }
    }
}
