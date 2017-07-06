using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    class MensajeBO
    {
        public int Codigo { get; set; }
        public int Status { get; set; }
        public string Destinatario { get; set; }
        public string Remitente { get; set; }
        public string Cuerpo { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoEvento { get; set; }
    }
}
