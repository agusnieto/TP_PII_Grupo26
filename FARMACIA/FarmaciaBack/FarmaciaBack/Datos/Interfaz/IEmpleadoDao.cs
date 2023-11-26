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
<<<<<<< HEAD
        //EmpleadoDTO GetEmpleadoDTO(int id);
=======
>>>>>>> 26b4dde95d66fc9f39cdb4c0e73787f240f5b1d2
        bool PostEmpleado(EmpleadoDTO empleado);
        bool PutEmpleado(EmpleadoDTO empleado);
        bool DeleteEmpleado(int id);
    }
}
