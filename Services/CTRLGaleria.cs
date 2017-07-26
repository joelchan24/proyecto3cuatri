using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using BO;

namespace Services
{
   public class CTRLGaleria
    {
        Galeria obDao;
        public CTRLGaleria()
        {
            obDao = new Galeria();
        }
        public bool accion1(GaleriaBO obj, string acci)
        {
            switch (acci)
            {
                case "btnAgregar":
                    obDao.agregar(obj);
                    break;
                case "btnModificar":
                    obDao.ELIMINAR(obj);
                    break;
                case "btnEliminar":
                    obDao.modificar(obj);
                    break;
            }
            return true;
        }
    }
}
