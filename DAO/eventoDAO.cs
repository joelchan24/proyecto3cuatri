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
  public  class eventoDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO conectar = new conexionDAO();
        public int agregar(object agregar)
        {
            //INSERT INTO EVENTO(DESCRIPCION,NOMBRE,COSTO,FECHAAPERTURA,FECHACIERRE,FOTOPROMOCION,UBICACIONGEOGRAFICA,LATITUD,LONGITUD,APROVACION,DIRECCION,CATEGORIA,USUARIO)VALUES APROVACION=@aprova
            EventoBO obejto = (EventoBO)agregar;
              SqlCommand cmd = new SqlCommand("INSERT INTO EVENTO(DESCRIPCION ,NOMBRE,COSTO ,FECHAAPERTURA ,FECHACIERRE,FOTOPROMOCION,UBICACIONGEOGRAFICA,LATITUD,APROVACION,LONGITUD,DIRECCION,CATEGORIA,USUARIO) VALUES(@des,@nom,@cos,@feaper,@fecier,@foto,@ubicacion,@lat,@long,@aprova,@dirr,@cat,@codus)");
               cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = obejto.Descripcion;
              cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = obejto.Nombre;
              cmd.Parameters.Add("@cos", SqlDbType.Money).Value = obejto.costo;
              cmd.Parameters.Add("@feaper", SqlDbType.Date).Value = obejto.FechaApertura.ToString("yyyy/MM/dd"); ;
              cmd.Parameters.Add("@fecier", SqlDbType.Date).Value = obejto.FechaCierre.ToString("yyyy/MM/dd"); ;
              cmd.Parameters.Add("@foto", SqlDbType.VarChar).Value = obejto.FotoPromocion;
            cmd.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = obejto.UbicacionGeografica;
            cmd.Parameters.Add("@lat", SqlDbType.Date).Value = obejto.latitud;
            cmd.Parameters.Add("@long", SqlDbType.VarChar).Value = obejto.longitud;
            cmd.Parameters.Add("@aprova", SqlDbType.VarChar).Value = obejto.aprovacion;
            cmd.Parameters.Add("@dirr", SqlDbType.Int).Value = obejto.CodigoDireccion;
            cmd.Parameters.Add("@cat", SqlDbType.Int).Value = obejto.CodigoCategoria;
            cmd.Parameters.Add("@codus", SqlDbType.Int).Value = obejto.CodigoUsuario;
            cmd.CommandType = CommandType.Text;

              return conectar.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {
            // select * from EVENTO e inner join DIRECCION d on e.DIRECCION=d.CODIGO  
            SqlCommand cmd = new SqlCommand(" select * from  DIRECCION  ");
           

            cmd.CommandType = CommandType.Text;


            return conectar.EjecutarSentencia(cmd);
        }

        public int eliminar(object eliminar)
        {
            EventoBO obejto = (EventoBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete  from EVENTO where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;

              cmd.CommandType = CommandType.Text;


            return conectar.EjecutarComando(cmd);

        }

        public int modificar(object modificar)
        {
            EventoBO obejto = (EventoBO)modificar;
            SqlCommand cmd = new SqlCommand("update  EVENTO set DESCRIPCION=@des ,NOMBRE=@nom,COSTO=@cos ,FECHAAPERTURA=@feaper ,FECHACIERRE=@fecier,FOTOPROMOCION=@foto,UBICACIONGEOGRAFICA=@ubicacion,LATITUD=@lat,LONGITUD=@long,APROVACION=@aprova,DIRECCION=@dirr,CATEGORIA=@cat,USUARIO=@codus where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = obejto.Descripcion;
            cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = obejto.Nombre;
            cmd.Parameters.Add("@cos", SqlDbType.Money).Value = obejto.costo;
            cmd.Parameters.Add("@feaper", SqlDbType.Date).Value = obejto.FechaApertura;
            cmd.Parameters.Add("@fecier", SqlDbType.Date).Value = obejto.FechaCierre;
            cmd.Parameters.Add("@foto", SqlDbType.VarChar).Value = obejto.FotoPromocion;
            cmd.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = obejto.UbicacionGeografica;
            cmd.Parameters.Add("@lat", SqlDbType.Date).Value = obejto.latitud;
            cmd.Parameters.Add("@long", SqlDbType.VarChar).Value = obejto.longitud;
            cmd.Parameters.Add("@aprova", SqlDbType.VarChar).Value = obejto.aprovacion;
            cmd.Parameters.Add("@dirr", SqlDbType.Int).Value = obejto.CodigoDireccion;
            cmd.Parameters.Add("@cat", SqlDbType.Int).Value = obejto.CodigoCategoria;
            cmd.Parameters.Add("@codus", SqlDbType.Int).Value = obejto.CodigoUsuario;
            cmd.CommandType = CommandType.Text;

            return conectar.EjecutarComando(cmd);
        }
        public DataSet buscar_categoria()
        {
            SqlCommand cmd = new SqlCommand("select * from CATEGORIA ");


            cmd.CommandType = CommandType.Text;


            return conectar.EjecutarSentencia(cmd);
        }
        public DataSet buscar_municipio()
        {
            SqlCommand cmd = new SqlCommand("select * from MUNICIPIO ");


            cmd.CommandType = CommandType.Text;


            return conectar.EjecutarSentencia(cmd);
        }
    }
}
