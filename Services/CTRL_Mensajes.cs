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
    public class CTRL_Mensajes
    {
        MensajesDAO oMensajesDAO;
        public CTRL_Mensajes()
        {
            oMensajesDAO = new MensajesDAO();
        }
        public bool Accion(string strAccion, MensajeBO oMensajesBO)
        {
            switch (strAccion)
            {
                case "btn_Nuevo":
                    oMensajesDAO.agregar(oMensajesBO);
                    break;
                case "btn_Eliminar":
                    oMensajesDAO.eliminar(oMensajesBO);
                    break;
                case "btn_Modificar":
                    oMensajesDAO.modificar(oMensajesBO);
                    break;
                case "btn_Buscar":

                    break;
            }
            return true;
        }

        public DataSet listar()
        {
            return oMensajesDAO.buscar();

        }
    }
}
