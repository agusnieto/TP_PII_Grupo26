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
        public FacturaController()
        {
                
        }

        [HttpPost]
        public IActionResult Post([FromBody] Factura factura)
        {
            //dentro de un try catch
            try
            {
                if (factura == null)
                {
                    return BadRequest("Se esperaba un cliente con todos los datos");
                }
                if (ServicioDao.ObtenerServicio().CargarFactura(factura))
                {
                    return Ok("Factura cargada con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo cargar la factura");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }

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
        
        [HttpGet("Empleados/{sede}")]
        public IActionResult GetEmpleadosDTO(int sede)
        {
            List<EmpleadoDTO> empleados = ServicioDao.ObtenerServicio().ConsultarEmpleadosXSede(sede);
            if (empleados != null)
            {
                return Ok(empleados);
            }
            return NotFound("No se encontraron los empleados");
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
        [HttpGet("Productos")]
        public IActionResult GetProductos(int id)
        {
            Producto producto = ServicioDao.ObtenerServicio().GetProduto(id);
            if (producto != null)
            {
                return Ok(producto);
            }
            return NotFound("No se encontro el producto");
        }
    }
}
