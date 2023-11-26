using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Interfaz
{
    public interface IEmpleadoDao
    {
        List<Puesto> GetPuestos();
        List<Empleado> GetEmpleados();
        Empleado GetEmpleado(int id);
        List<EmpleadoDTO> GetEmpleadosDTO();
        bool PostEmpleado(EmpleadoDTO empleado);
        bool PutEmpleado(EmpleadoDTO empleado);
        bool DeleteEmpleado(int id);
    }
}
