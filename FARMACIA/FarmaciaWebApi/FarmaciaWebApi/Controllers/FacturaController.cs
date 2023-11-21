using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class FacturacionController : ControllerBase
        {
            [HttpGet("Sedes")]
            public IActionResult GetSedes()
            {
                List<Sede> lista = ServicioDao.ObtenerServicio().ConsultarSedes();
                if (lista != null)
                {
                    return Ok(lista);
                }
                return NotFound("No hay Sedes cargadas");
            }

            [HttpGet("ServicioDTO")]
            public IActionResult Get() // IActionResult devuelve un Json y un Codigo OK 200
            {
                List<ServicioDTO> lista = ServicioDao.ObtenerServicio().GetServicioDTO();
                if (lista != null)
                {
                    return Ok(lista);
                }
                return NotFound("No hay servicios cargados");
            }
            [HttpGet("EmpleadosDTO")]
            public IActionResult GetEmpleados(int sede)
            {
                List<EmpleadoDTO> lista = ServicioDao.ObtenerServicio().ConsultarEmpleados(sede);
                if (lista != null)
                {
                    return Ok(lista);
                }
                return NotFound("No hay empleados cargados");
            }
            [HttpGet("{id}")]
            public IActionResult GetEmpleados(int id)
            {
                EmpleadoDTO empleado = ServicioDao.ObtenerServicio().ConsultarEmpleado(id);
                if (empleado != null)
                {
                    return Ok(empleado);
                }
                return NotFound("No se encontro el empleado");
            }
            [HttpGet("ClientesDTO")]
            public IActionResult GetClientesDTO()
            {
                List<ClienteDTO> lista = ServicioDao.ObtenerServicio().ConsultarClientesDTO();
                if (lista != null)
                {
                    return Ok(lista);
                }
                return NotFound("No hay clientes cargados");
            }
            [HttpGet("Pagos")]
            public IActionResult GetPagos()
            {
                List<FormaPago> lista = ServicioDao.ObtenerServicio().ConsultarFormasPago();
                if (lista != null)
                {
                    return Ok(lista);
                }
                return NotFound("No se encontraron formas de pago");
            }
            [HttpGet("Envios")]
            public IActionResult GetEnvios()
            {
                List<FormaEnvio> lista = ServicioDao.ObtenerServicio().ConsultarFormasEnvio();
                if (lista != null)
                {
                    return Ok(lista);
                }
                return NotFound("No se encontraron formas de envio");
            }
        }
    }
}
