using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        // GET: api/<ProveedorController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Proveedor> lista = ServicioDao.ObtenerServicio().ConsultarProveedoresCompletos();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }
        [HttpGet("RazonesSociales")]
        public IActionResult GetRazonSocial()
        {
            List<RazonSocial> lista = ServicioDao.ObtenerServicio().ConsultarRazonesSociales();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }

        // GET api/<EmpleadoController>/5
        /*[HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ProveedorDTO proveedor = ServicioDao.ObtenerServicio().ConsultarProveedorDTO(id);
            if (proveedor != null)
            {
                return Ok(proveedor);
            }
            return NoContent();
        }*/

        // POST api/<EmpleadoController>
        [HttpPost]
        public IActionResult Post([FromBody] ProveedorDTO proveedor)
        {
            //dentro de un try catch
            try
            {
                if (proveedor == null)
                {
                    return BadRequest("Se esperaba un proveedor con todos los datos");
                }
                //if (cliente.) validaciones por si es un objeto valido.
                if (ServicioDao.ObtenerServicio().CargarProveedor(proveedor))
                {
                    return Ok("Proveedor registrado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo registrar el proveedor");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut]
        public IActionResult Put([FromBody] ProveedorDTO proveedor)
        {
            //dentro de un try catch
            try
            {
                if (proveedor == null)
                {
                    return BadRequest("Se esperaba un empleado con todos los datos");
                }
                //if (cliente.) validaciones por si es un objeto valido.
                if (ServicioDao.ObtenerServicio().ActualizarProveedor(proveedor))
                {
                    return Ok("Proveedor actualizado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo actualizar el proveedor");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //dentro de un try catch
            try
            {
                if (id == null)
                {
                    return BadRequest("Se esperaba un identificador de un empleado");
                }

                if (ServicioDao.ObtenerServicio().EliminarProveedor(id))
                {
                    return Ok("Provedor eliminado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo eliminar el cliente");
                }

            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
    }
}
