using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.DTOs
{
    public class ProveedorDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int RazonSocial { get; set; }
        public int Barrio { get; set; }
        public string? Calle { get; set; }
        public long Cuit { get; set; }       
        public long Telefono { get; set; }
        public string Email { get; set; }

    }
}
