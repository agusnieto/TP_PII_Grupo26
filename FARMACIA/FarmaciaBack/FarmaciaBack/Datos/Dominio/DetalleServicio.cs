using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class DetalleServicio
    {
        public int IdDetalle { get; set; }
        public int NroFactura { get; set; }
        public Medico Medico { get; set; }
        public Servicio Servicio { get; set; }
        public double Precio { get; set; }
        public int Atencion { get; set; }
        public int Descuento { get; set; }
    }
}
