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
    public class QuienesSomosDAO
    {
        conexionDAO obj = new conexionDAO();

        public int agregar(object agregar)
        {
            QuienesSomosBO QuienesSomos = (QuienesSomosBO)agregar;
            SqlCommand cmd = new SqlCommand("insert into QUIENESSOMOS values (@descripcion)");
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = QuienesSomos.descripcion;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
            
        }

        public DataSet buscar(object buscar)
        {
            QuienesSomosBO QuienesSomos = (QuienesSomosBO)buscar;
            SqlCommand cmd = new SqlCommand("select * from QUIENESSOMOS where DESCRIPCION=@descripcion");
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = QuienesSomos.descripcion;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);


        }

        public int eliminar(object eliminar)
        {
            QuienesSomosBO QuienesSomos = (QuienesSomosBO)eliminar;
            SqlCommand cmd = new SqlCommand("delete from QUIENESSOMOS where CODIGO=@CODIGO");
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = QuienesSomos.descripcion;
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = QuienesSomos.id_Quienes;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public int modificar(object modificar)
        {
            QuienesSomosBO QuienesSomos = (QuienesSomosBO)modificar;
            SqlCommand cmd = new SqlCommand("update QUIENESSOMOS set DESCRIPCION=@descripcion where CODIGO=@CODIGO");
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = QuienesSomos.descripcion;
            cmd.Parameters.Add("@CODIGO", SqlDbType.Int).Value = QuienesSomos.id_Quienes;
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarComando(cmd);
        }

        public DataSet listar()
        {
            SqlCommand cmd = new SqlCommand("select * from QUIENESSOMOS");
            cmd.CommandType = CommandType.Text;
            return obj.EjecutarSentencia(cmd);

        }
    }
}
