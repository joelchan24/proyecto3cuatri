﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
  public  class EventoBO
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public double costo { get; set; }
        public string FotoPromocion { get; set; }
        public string UbicacionGeografica { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public string aprovacion { get; set; }
        public int visitas { get; set; }
        public int CodigoDireccion { get; set; }
        public int CodigoCategoria { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoHorario { get; set; }
        public int Codigo_dir { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public string Cruzamiento { get; set; }
        public string NumeroInterior { get; set; }
        public string NumeroExterior { get; set; }
        public int CodigoMunicipio { get; set; }
    }
}
