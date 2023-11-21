using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.DTOs
{
    public class MedicoDTO
    {
        public int Id { get; set; }
        public string? NombreCompleto { get; set; }   
        
        public string Nombre {  get; set; }
        public string Apellido {  get; set; }
        public int Matricula { get; set; }

        public int ObraSocial { get; set; }
        public int Sede { get; set; }
        public DateTime FechaIngreso { get; set; }
        
        public long Telefono {  get; set; }

        public string Email { get; set; }
    }
}
