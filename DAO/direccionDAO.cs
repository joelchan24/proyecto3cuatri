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
  public  class direccionDAO : interface_metodos_guardar_eliminar_actualizar_buscar
    {
        conexionDAO conectar = new conexionDAO();
        public int agregar(object agregar)
        {
            Direccion obejto = (Direccion)agregar;
            SqlCommand cmd = new SqlCommand("INSERT INTO DIRECCION(COLONIA,CODIGOPOSTAL,CRUZAMIENTO,NUMEROINTERIOR,NUMEROEXTERIOR ,MUNICIPIO) values(@col,@pos,@cru,@numin,@numex,@muni)");
            cmd.Parameters.Add("@col", SqlDbType.VarChar).Value = obejto.Colonia;
            cmd.Parameters.Add("@pos", SqlDbType.Char).Value = obejto.CodigoPostal;
            cmd.Parameters.Add("@cru", SqlDbType.VarChar).Value = obejto.Cruzamiento;
            cmd.Parameters.Add("@numin", SqlDbType.VarChar).Value = obejto.NumeroInterior;
            cmd.Parameters.Add("@numex", SqlDbType.VarChar).Value = obejto.NumeroExterior;
            cmd.Parameters.Add("@muni", SqlDbType.Int).Value = obejto.CodigoMunicipio;
            cmd.CommandType = CommandType.Text;

            return conectar.EjecutarComando(cmd);
        }

        public DataSet buscar()
        {
            SqlCommand obj = new SqlCommand("select max(CODIGO) from USUARIOS");
            obj.CommandType = CommandType.Text;

            return conectar.EjecutarSentencia(obj);
        }

        public int eliminar(object eliminar)
        {
            Direccion obejto = (Direccion)eliminar;
            SqlCommand cmd = new SqlCommand("delete  from DIRECCION where CODIGO=@cod");

            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;
            cmd.CommandType = CommandType.Text;

            return conectar.EjecutarComando(cmd);


        }

        public int modificar(object modificar)
        {
            Direccion obejto = (Direccion)modificar;
            SqlCommand cmd = new SqlCommand("update  DIRECCION set COLONIA=@col,CODIGOPOSTAL=@pos,CRUZAMIENTO=@cru,NUMEROINTERIOR=@numin,NUMEROEXTERIOR=@numex ,MUNICIPIO=@muni where CODIGO=@cod");
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = obejto.Codigo;
            cmd.Parameters.Add("@col", SqlDbType.VarChar).Value = obejto.Colonia;
            cmd.Parameters.Add("@pos", SqlDbType.Char).Value = obejto.CodigoPostal;
            cmd.Parameters.Add("@cru", SqlDbType.VarChar).Value = obejto.Cruzamiento;
            cmd.Parameters.Add("@numin", SqlDbType.VarChar).Value = obejto.NumeroInterior;
            cmd.Parameters.Add("@numex", SqlDbType.VarChar).Value = obejto.NumeroExterior;
            cmd.Parameters.Add("@muni", SqlDbType.Int).Value = obejto.CodigoMunicipio;
            cmd.CommandType = CommandType.Text;

            return conectar.EjecutarComando(cmd);
        }
    }
}
