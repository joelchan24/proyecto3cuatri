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
    class CTRL_QuienesSomos
    {
        QuienesSomosDAO oQuienesSomosDAO;

        public CTRL_QuienesSomos()
        {
            oQuienesSomosDAO = new QuienesSomosDAO();
        }

        public bool Accion(string strAccion, QuienesSomosBO oQuienesSomosBO)
        {
            switch(strAccion)
            {
                case "btnAgregar":
                    oQuienesSomosDAO.agregar(oQuienesSomosBO);
                    break;
                case "btnEliminar":
                    oQuienesSomosDAO.eliminar(oQuienesSomosBO);
                    break;
                case "btnModificar":
                    oQuienesSomosDAO.modificar(oQuienesSomosBO);
                    break;
                case "btnBuscar":
                    oQuienesSomosDAO.buscar(oQuienesSomosBO);
                    break;
                    
            }
            return true;
        }

        public DataSet listar()
        {
            return oQuienesSomosDAO.listar();
        }
    }
}
