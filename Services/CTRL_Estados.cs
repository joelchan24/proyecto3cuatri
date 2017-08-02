using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAO;
using System.Data;

namespace Services
{
    public class CTRL_Estados
    {
        EstadoDAO oEstadosDAO;
        public CTRL_Estados()
        {
            oEstadosDAO = new EstadoDAO();
        }

        public bool Accion(string strAccion, EstadoBO oEstadosBO)
        {
            switch (strAccion)
            {
                case "btnAgregar":
                    oEstadosDAO.agregar(oEstadosBO);
                    break;
                case "btn_Eliminar":
                    oEstadosDAO.eliminar(oEstadosBO);
                    break;
                case "btn_Modificar":
                    oEstadosDAO.modificar(oEstadosBO);
                    break;
                case "btn_Buscar":
                   
                    break;
            }
            return true;
        }

        public DataSet listar()
        {
            return oEstadosDAO.listar();

        }
    }
}
