using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.DTOs
{
    public class EmpleadoDTO
    {
        public int Legajo { get; set; }
        public string? NombreCompleto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Puesto { get; set; }
        public double Sueldo { get; set; }
        public int Sede { get; set; }

        public DateTime FechaIngreso { get; set; }
        public DateTime FechaBaja { get; set; }
        public bool Activo { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }

        public EmpleadoDTO() { }
        public EmpleadoDTO(int id, string nombreCompleto)
        {
            Legajo = id;
            NombreCompleto = nombreCompleto;
        }
        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
