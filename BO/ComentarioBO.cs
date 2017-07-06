using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    class ComentarioBO
    {
        public int Codigo { get; set; }
        public string Comentario { get; set; }
        public int CodigoEvento { get; set; }
        public int CodigoUsuario { get; set; }
    }
}
