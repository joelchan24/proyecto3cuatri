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
    public class CTRL_Municipio
    {

        MunicipioDAO oMunicipioDAO;
        public CTRL_Municipio()
        {
            oMunicipioDAO = new MunicipioDAO();
        }

        public bool Accion(string strAccion, MunicipioBO oMunicipioBO)
        {
            switch (strAccion)
            {
                case "btn_Nuevo":
                    oMunicipioDAO.agregar(oMunicipioBO);
                    break;
                case "btn_Eliminar":
                    oMunicipioDAO.eliminar(oMunicipioBO);
                    break;
                case "btn_Modificar":
                    oMunicipioDAO.modificar(oMunicipioBO);
                    break;
                case "btn_Buscar":

                    break;
            }
            return true;
        }

        public DataSet listar()
        {
            return oMunicipioDAO.listar();

        }
    }
}
