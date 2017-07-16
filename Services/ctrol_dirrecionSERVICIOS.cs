using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAO;
namespace Services
{
   public class ctrol_dirrecionSERVICIOS
    {
        direccionDAO objdai;
        public ctrol_dirrecionSERVICIOS()
        {
            objdai = new direccionDAO();
        }

        public bool accion(Direccion dire, string str_accion)
        {
            switch (str_accion)
            {
                case "bnt_agregar":
                    objdai.agregar(dire);
                    break;
                case "bnt_eliminar":
                    objdai.eliminar(dire);
                    break;
                case "btn_modificar":
                    objdai.modificar(dire);
                    break;
                case "btn_limpiar":

                    break;



            }
            return true;

        }


    }
}
