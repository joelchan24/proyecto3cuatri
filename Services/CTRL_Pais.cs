using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using BO;
using System.Data;

namespace Services
{
   public class CTRL_Pais
    {
        PaisDAO oPaisDAO;
        public CTRL_Pais()
        {
            oPaisDAO = new PaisDAO();
        }

        public bool Accion(string strAccion, PaisBO oPaisBO)
        {
            switch (strAccion)
            {
                case "btn_Nuevo":
                    oPaisDAO.agregar(oPaisBO);
                    break;
                case "btn_Eliminar":
                    oPaisDAO.eliminar(oPaisBO);
                    break;
                case "btn_Modificar":
                    oPaisDAO.modificar(oPaisBO);
                    break;
                case "btn_Buscar":

                    break;
            }
            return true;
        }

        public DataSet listar()
        {
            return oPaisDAO.listar();

        }
    }
}
