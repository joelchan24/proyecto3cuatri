using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class UsuarioBO
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimineto { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Fotografia { get; set; }
        public int Codigo_Direccion { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public string Cruzamiento { get; set; }
        public string NumeroInterior { get; set; }
        public string NumeroExterior { get; set; }
        public int CodigoMunicipio { get; set; }
        public int IDCUENTA { get; set; }

    }
}
