using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAO;
namespace Services
{
   public class CTRLComentario
    {
        ComentarioDAO obj;
        public CTRLComentario()
        {
            obj = new ComentarioDAO();

        }
        public bool Comentario(ComentarioBO objcomentario,string accion)
        {
            switch (accion)
            {
                case "btnAgregar":
                    obj.agregar(objcomentario);
                    break;
                case "btnModificar":
                    obj.alterar(objcomentario);
                    break;
                case "btnEliminar":
                    obj.eliminar(objcomentario);
                    break;

            }
            return true;
        }
    }
}
