using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.DTOs
{
    public class DetalleFacturaDTO
    {
        public int Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
