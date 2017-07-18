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
        Direccion Direccion;
        conexionDAO conectar = new conexionDAO();
        public int agregar(object agregar)
        {
           //INSERT INTO EVENTO(DESCRIPCION,NOMBRE,COSTO,FECHAAPERTURA,FECHACIERRE,FOTOPROMOCION,UBICACIONGEOGRAFICA,LATITUD,LONGITUD,APROVACION,DIRECCION,CATEGORIA,USUARIO)VALUES APROVACION=@aprova
           
           EventoBO obejto = (EventoBO)agregar;
               SqlCommand dir = new SqlCommand("INSERT INTO DIRECCION(COLONIA,CODIGOPOSTAL,CRUZAMIENTO,NUMEROINTERIOR,NUMEROEXTERIOR ,MUNICIPIO) output" + " inserted.CODIGO values(@col,@pos,@cru,@numin,@numex,@muni)");
            // dir.Parameters.AddWithValue
            // int id =dir.ExecuteNonQuery();
            //   conectar.EjecutarComando(dir);
            dir.Parameters.Add("@col", SqlDbType.VarChar).Value = obejto.Colonia;//----
            dir.Parameters.Add("@pos", SqlDbType.Char).Value = obejto.CodigoPostal;
            dir.Parameters.Add("@cru", SqlDbType.VarChar).Value = obejto.Cruzamiento;
            dir.Parameters.Add("@numin", SqlDbType.VarChar).Value = obejto.NumeroInterior;
            dir.Parameters.Add("@numex", SqlDbType.VarChar).Value = obejto.NumeroExterior;
            dir.Parameters.Add("@muni", SqlDbType.Int).Value = obejto.CodigoMunicipio;//--

            int id = conectar.EjecutarComando(dir);


            SqlCommand cmd = new SqlCommand("INSERT INTO EVENTO(DESCRIPCION ,NOMBRE,COSTO ,FECHAAPERTURA ,FECHACIERRE,FOTOPROMOCION,UBICACIONGEOGRAFICA,LATITUD,LONGITUD,APROVACION,DIRECCION,CATEGORIA,USUARIO)  VALUES(@des,@nom,@cos,@feaper,@fecier,@foto,@ubicacion,@lat,@long,@aprova,'" + id + "',@cat,@codus)");

          

            
          /*  cmd.Parameters.Add("@col", SqlDbType.VarChar).Value = obejto.Colonia;//----
            cmd.Parameters.Add("@pos", SqlDbType.Char).Value = obejto.CodigoPostal;
            cmd.Parameters.Add("@cru", SqlDbType.VarChar).Value = obejto.Cruzamiento;
            cmd.Parameters.Add("@numin", SqlDbType.VarChar).Value = obejto.NumeroInterior;
            cmd.Parameters.Add("@numex", SqlDbType.VarChar).Value = obejto.NumeroExterior;
            cmd.Parameters.Add("@muni", SqlDbType.Int).Value = obejto.CodigoMunicipio;//--*/
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = obejto.Descripcion;
              cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = obejto.Nombre;
              cmd.Parameters.Add("@cos", SqlDbType.Money).Value = obejto.costo; 
              cmd.Parameters.Add("@feaper", SqlDbType.Date).Value = obejto.FechaApertura.ToString("yyyy-MM-dd"); 
              cmd.Parameters.Add("@fecier", SqlDbType.Date).Value = obejto.FechaCierre.ToString("yyyy-MM-dd"); 
              cmd.Parameters.Add("@foto", SqlDbType.VarChar).Value = obejto.FotoPromocion;
            cmd.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = obejto.UbicacionGeografica;
            cmd.Parameters.Add("@lat", SqlDbType.VarChar).Value = obejto.latitud;
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
            SqlCommand cmd = new SqlCommand(" select * from EVENTO e inner join DIRECCION d on e.DIRECCION=d.CODIGO  ");
           

            cmd.CommandType = CommandType.Text;


            return conectar.EjecutarSentencia(cmd);
        }

        public int eliminar(object eliminar)
        {
             EventoBO obejto = (EventoBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete  from EVENTO where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;
            cmd.CommandType = CommandType.Text;

            int evento = conectar.EjecutarComando(cmd);
            //
            SqlCommand eliminardir = new SqlCommand("delete  from DIRECCION where CODIGO=@codi");

            eliminardir.Parameters.Add("@codi", SqlDbType.Int).Value = obejto.Codigo_dir;
            eliminardir.CommandType = CommandType.Text;
            int dirrecion = conectar.EjecutarComando(eliminardir);
            //
           
           

            int respuesta = ((dirrecion != 0) && (evento != 0)) ? 1 : 0;

            return respuesta;

        }

        public int modificar(object modificar)
        {
            EventoBO obejto = (EventoBO)modificar;
            SqlCommand cmd = new SqlCommand("update  EVENTO set DESCRIPCION=@des ,NOMBRE=@nom,COSTO=@cos ,FECHAAPERTURA=@feaper ,FECHACIERRE=@fecier,FOTOPROMOCION=@foto,UBICACIONGEOGRAFICA=@ubicacion,LATITUD=@lat,LONGITUD=@long,APROVACION=@aprova,DIRECCION=@dirr,CATEGORIA=@cat,USUARIO=@codus where CODIGO=@codigo");
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = obejto.Codigo;
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = obejto.Descripcion;
            cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = obejto.Nombre;
            cmd.Parameters.Add("@cos", SqlDbType.Money).Value = obejto.costo;
            cmd.Parameters.Add("@feaper", SqlDbType.Date).Value = obejto.FechaApertura.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@fecier", SqlDbType.Date).Value = obejto.FechaCierre.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@foto", SqlDbType.VarChar).Value = obejto.FotoPromocion;
            cmd.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = obejto.UbicacionGeografica;
            cmd.Parameters.Add("@lat", SqlDbType.VarChar).Value = obejto.latitud;
            cmd.Parameters.Add("@long", SqlDbType.VarChar).Value = obejto.longitud;
            cmd.Parameters.Add("@aprova", SqlDbType.VarChar).Value = obejto.aprovacion;
            cmd.Parameters.Add("@dirr", SqlDbType.Int).Value = obejto.Codigo_dir;
            cmd.Parameters.Add("@cat", SqlDbType.Int).Value = obejto.CodigoCategoria;
            cmd.Parameters.Add("@codus", SqlDbType.Int).Value = obejto.CodigoUsuario;
            cmd.CommandType = CommandType.Text;

            int actualizar_evento = conectar.EjecutarComando(cmd);


            SqlCommand dire = new SqlCommand("update  DIRECCION set COLONIA=@col,CODIGOPOSTAL=@pos,CRUZAMIENTO=@cru,NUMEROINTERIOR=@numin,NUMEROEXTERIOR=@numex ,MUNICIPIO=@muni where CODIGO=@codi");
            dire.Parameters.Add("@codi", SqlDbType.Int).Value = obejto.Codigo_dir;
            dire.Parameters.Add("@col", SqlDbType.VarChar).Value = obejto.Colonia;
            dire.Parameters.Add("@pos", SqlDbType.Char).Value = obejto.CodigoPostal;
            dire.Parameters.Add("@cru", SqlDbType.VarChar).Value = obejto.Cruzamiento;
            dire.Parameters.Add("@numin", SqlDbType.VarChar).Value = obejto.NumeroInterior;
            dire.Parameters.Add("@numex", SqlDbType.VarChar).Value = obejto.NumeroExterior;
            dire.Parameters.Add("@muni", SqlDbType.Int).Value = obejto.CodigoMunicipio;
            dire.CommandType = CommandType.Text;

            int actualizar_dir = conectar.EjecutarComando(dire);
      
         

            int Respuesta = ((actualizar_dir != 0) && (actualizar_evento != 0)) ? 1 : 0;
            return Respuesta;
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
