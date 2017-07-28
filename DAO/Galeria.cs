using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
   public class Galeria
    {
        conexionDAO conex;
        public Galeria()
        {
            conex = new conexionDAO();
        }
       public DataSet listarevento(int id)
        {
            SqlCommand cmd = new SqlCommand("  SELECT CODIGO,NOMBRE FROM EVENTO WHERE USUARIO=@COD");
            cmd.Parameters.Add("@COD", SqlDbType.Int).Value = id;
            cmd.CommandType = CommandType.Text;
            return conex.EjecutarSentencia(cmd);

        }
        public int agregar(object datos)
        {
            GaleriaBO obj = (GaleriaBO)datos;
            SqlCommand cmd = new SqlCommand("insert into GALERIA(FOTO,IDEVENTO)VALUES(@FOT,@EVENTO)");
            cmd.Parameters.Add("@FOT", SqlDbType.VarChar).Value = obj.Foto;
            cmd.Parameters.Add("@EVENTO", SqlDbType.Int).Value = obj.IDEVENTO;
            cmd.CommandType = CommandType.Text;
            return conex.EjecutarComando(cmd);
        }
        public int ELIMINAR(object eliminar)
        {
            GaleriaBO obj = (GaleriaBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete FROM GALERIA WHERE CODIGO=@COD");
            cmd.Parameters.Add("@COD", SqlDbType.Int).Value = obj.Codigo;
            return conex.EjecutarComando(cmd);
        }
        public int modificar(object modificar)
        {
            GaleriaBO obj = (GaleriaBO)modificar;
            SqlCommand cmd = new SqlCommand("UPDATE GALERIA SET FOTO=@FOT,IDEVENTO=@EVENTO WHERE CODIGO=@COD");
            cmd.Parameters.Add("@FOT", SqlDbType.VarChar).Value = obj.Foto;
            cmd.Parameters.Add("@EVENTO", SqlDbType.Int).Value = obj.IDEVENTO;
            cmd.Parameters.Add("@COD", SqlDbType.Int).Value = obj.Codigo;
            return conex.EjecutarComando(cmd);
        }
        public DataSet listarimagenes(int id)
        {
            SqlCommand cmd = new SqlCommand("  select h.*,e.NOMBRE FROM GALERIA h inner join EVENTO e on h.IDEVENTO=e.CODIGO inner join USUARIOS ON E.USUARIO=@cod");
            cmd.Parameters.Add("cod", SqlDbType.Int).Value = id;
            cmd.CommandType = CommandType.Text;
            return conex.EjecutarSentencia(cmd);
        }
    }
}
