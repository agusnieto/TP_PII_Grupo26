using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.DTOs
{
    public class DetalleServicioDTO
    {
        public int Medico { get; set; }
        public int Servicio { get; set; }
        public double Precio { get; set; }
        public int Atencion { get; set; }
        public int Descuento { get; set; }
    }
}
