using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.DTOs
{
    public class EmpleadoDTO
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public EmpleadoDTO() { }
        public EmpleadoDTO(int id, string nombreCompleto)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
        }
    }
}
