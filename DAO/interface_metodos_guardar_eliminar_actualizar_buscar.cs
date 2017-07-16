using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    interface interface_metodos_guardar_eliminar_actualizar_buscar
    {

        int agregar(object agregar);
        int eliminar(object eliminar);
        int modificar(object modificar);
        DataSet buscar();









    }
}
