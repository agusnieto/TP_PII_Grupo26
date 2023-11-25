using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.DTOs
{
    public class FacturaDTO
    {
        public int NroFactura { get; set; }
        public int Empleado { get; set; }
        public int Cliente { get; set; }
        public int FormaPago { get; set; }
        public int Sede { get; set; }
        public int Envio { get; set; }
        public List<DetalleFacturaDTO> DetalleFactura { get; set; }
        public List<DetalleServicioDTO> DetalleServicio { get; set; }
    }
}
