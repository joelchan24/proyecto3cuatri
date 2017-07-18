using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BO;

namespace DAO
{
    public class MensajesDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO conectar = new conexionDAO();
        public int agregar(object agregar)
        {
            MensajeBO obejto = (MensajeBO)agregar;
            SqlCommand cmd = new SqlCommand("INSERT INTO MENSAJES(MESTATUS ,DESTINATARIO,REMITENTE ,CUERPO ,USUARIO,EVENTO) VALUES(@mes,@des,@rem,@cue,@usu,@eve)");
            cmd.Parameters.Add("@mes", SqlDbType.Bit).Value = obejto.Status;
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = obejto.Destinatario;
            cmd.Parameters.Add("@rem", SqlDbType.VarChar).Value = obejto.Remitente;
            cmd.Parameters.Add("@cue", SqlDbType.VarChar).Value = obejto.Cuerpo;
            cmd.Parameters.Add("@usu", SqlDbType.Int).Value = obejto.CodigoUsuario;
            cmd.Parameters.Add("@eve", SqlDbType.Int).Value = obejto.CodigoEvento;
            cmd.CommandType = CommandType.Text;

            return conectar.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {
            SqlCommand cmd = new SqlCommand(" select * from  MENSAJES  ");


            cmd.CommandType = CommandType.Text;


            return conectar.EjecutarSentencia(cmd);
        }

        public int eliminar(object eliminar)
        {
            MensajeBO obejto = (MensajeBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete  from MENSAJES where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;

            cmd.CommandType = CommandType.Text;


            return conectar.EjecutarComando(cmd);
        }

        public int modificar(object modificar)
        {
            MensajeBO obejto = (MensajeBO)modificar;
            SqlCommand cmd = new SqlCommand("update  MENSAJES set MESTATUS=@mes ,DESTINATARIO=@des,REMITENTE=@rem ,CUERPO=@cue ,USUARIO=@usu,EVENTO=@eve where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;
            cmd.Parameters.Add("@mes", SqlDbType.Bit).Value = obejto.Status;
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = obejto.Destinatario;
            cmd.Parameters.Add("@rem", SqlDbType.VarChar).Value = obejto.Remitente;
            cmd.Parameters.Add("@cue", SqlDbType.VarChar).Value = obejto.Cuerpo;
            cmd.Parameters.Add("@usu", SqlDbType.Int).Value = obejto.CodigoUsuario;
            cmd.Parameters.Add("@eve", SqlDbType.Int).Value = obejto.CodigoEvento;
            cmd.CommandType = CommandType.Text;
            return conectar.EjecutarComando(cmd);
           
        }
    }
}
