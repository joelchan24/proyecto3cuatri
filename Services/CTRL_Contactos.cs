using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BO;
using DAO;

namespace Services
{
   public class CTRL_Contactos
    {
        ContactosDAO oContactosDAO;

        public CTRL_Contactos()
        {
            oContactosDAO = new ContactosDAO();
        }

        public bool Accion(string strAccion, ContactosBO oContactosBO)
        {
            switch(strAccion)
            {
                case "btnAgregar":
                    oContactosDAO.agregar(oContactosBO);
                    break;
                case "btnEliminar":
                    oContactosDAO.eliminar(oContactosBO);
                    break;
                case "btnModificar":
                    oContactosDAO.modificar(oContactosBO);
                    break;
                case "btnBuscar":
                    oContactosDAO.buscar();
                    
                    break;

            }
            return true;
        }

        public DataSet listar()
        {
            return oContactosDAO.listar();
        }
    }
}
