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
    public class CTRL_comentario
    {
        ComentarioDAO oComentarioDAO;
        public CTRL_comentario()
        {
            oComentarioDAO = new ComentarioDAO();
        }
        public bool Accion(string strAccion, ComentarioBO oComentarioBO)
        {
            switch (strAccion)
            {
                case "btn_Nuevo":
                    oComentarioDAO.agregar(oComentarioBO);
                    break;
                case "btn_Eliminar":
                    oComentarioDAO.eliminar(oComentarioBO);
                    break;
                case "btn_Modificar":
                    oComentarioDAO.modificar(oComentarioBO);
                    break;
                case "btn_Buscar":
                    
                    break;
            }
            return true;
        }

        public DataSet listar()
        {
            return oComentarioDAO.buscar();

        }
    }
}
