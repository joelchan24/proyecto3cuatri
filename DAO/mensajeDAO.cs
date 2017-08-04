using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;



namespace DAO
{
  public  class mensajeDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO conectar = new conexionDAO();
        int fila = 0;
        public int agregar(object agregar)
        {
            MensajeBO mensa = (MensajeBO)agregar;
            SqlCommand coma = new SqlCommand("INSERT INTO MENSAJES(MESTATUS,DESTINATARIO,REMITENTE,CUERPO,USUARIO)VALUES (@mensa,@des,@rem,@cuerpo,@id_usu)");
            coma.Parameters.Add("@mensa", SqlDbType.Bit).Value = mensa.Status;
            coma.Parameters.Add("@des", SqlDbType.VarChar).Value = mensa.Destinatario;
            coma.Parameters.Add("@rem", SqlDbType.VarChar).Value = mensa.Remitente;
            coma.Parameters.Add("@cuerpo", SqlDbType.VarChar).Value = mensa.Cuerpo;
            coma.Parameters.Add("@id_usu", SqlDbType.Int).Value = mensa.CodigoUsuario;
       

            coma.CommandType = CommandType.Text;
            return conectar.EjecutarComando(coma);






        }

        public DataSet buscar()
        {

            SqlCommand coma = new SqlCommand("select  * from MENSAJES where MESTATUS=0 and DESTINATARIO='ORGANIZADOR'");
            coma.CommandType = CommandType.Text;
            return conectar.EjecutarSentencia(coma);
        }

        public int eliminar(object eliminar)
        {
            MensajeBO mensa = (MensajeBO)eliminar;
            SqlCommand coma = new SqlCommand("delete from MENSAJES where CODIGO=@id");
            coma.Parameters.Add("@id", SqlDbType.Int).Value = mensa.Codigo;
  

            coma.CommandType = CommandType.Text;
            return conectar.EjecutarComando(coma);


        }

        public int modificar(object modificar)
        {
            MensajeBO mensa = (MensajeBO)modificar;
            SqlCommand coma = new SqlCommand("update  MENSAJES set CUERPO=@cuerpo where CODIGO=@id");
            coma.Parameters.Add("@id", SqlDbType.Int).Value = mensa.Codigo;
           
            coma.Parameters.Add("@cuerpo", SqlDbType.VarChar).Value = mensa.Cuerpo;
          

            coma.CommandType = CommandType.Text;
            return conectar.EjecutarComando(coma);


        }

        public int modificarmensajedao(MensajeBO mensaje)
        {
           
            
            SqlCommand comando = new SqlCommand("update mensajes set MESTATUS=1 , CUERPO=@cuerpo where CODIGO=@id");

            comando.Parameters.Add("@id", SqlDbType.Int).Value = mensaje.Codigo ;
            comando.Parameters.Add("@cuerpo", SqlDbType.VarChar).Value = mensaje.Cuerpo;

            return conectar.EjecutarComando(comando);
        }
        public int modificarmensajedao1(int valor)
        {


            SqlCommand comando = new SqlCommand("update mensajes set MESTATUS=0 where CODIGO=@id");

            comando.Parameters.Add("@id", SqlDbType.Int).Value = valor;

            return conectar.EjecutarComando(comando);
        }

        public DataSet buscar1()
        {

            SqlCommand coma = new SqlCommand("select  * from MENSAJES where MESTATUS=1");
            coma.CommandType = CommandType.Text;
            return conectar.EjecutarSentencia(coma);
        }
        public DataSet usuario(int val)
        {

            SqlCommand coma = new SqlCommand("    select * from usuarios where codigo!=@id ");
            coma.CommandType = CommandType.Text;
            coma.Parameters.Add("@id", SqlDbType.Int).Value = val;
            return conectar.EjecutarSentencia(coma);
        }
        public DataSet buscarmensaje(int val)
        {

            SqlCommand coma = new SqlCommand("select * from MENSAJES where DESTINATARIO=@id");
            coma.Parameters.Add("@id", SqlDbType.Int).Value = val;
            coma.CommandType = CommandType.Text;
            return conectar.EjecutarSentencia(coma);
        }





    }
}
