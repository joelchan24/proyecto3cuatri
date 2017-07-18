using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAO;
namespace Services
{
  public  class ctrol_usuarioSERVICIOS
    {
        usuarioDAO objetodao;
        public ctrol_usuarioSERVICIOS()
        {
            objetodao = new usuarioDAO();
        }


        public bool accion1(UsuarioBO usuarioBO, string str_accion)//asi se mando el bo que se recolecto yel evento de los botonos como sobre cargas
        {
            switch (str_accion)
            {
                case "btnAgregar":
                    objetodao.agregar(usuarioBO);
                    break;
                case "bnt_eliminar":
                    
                    break;
                case "btn_modificar":
                  
                    break;
                case "btn_limpiar":

                    break;



            }
            return true;

        }

    }
}
