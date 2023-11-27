using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        // GET: api/<EmpleadoController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Empleado> lista = ServicioDao.ObtenerServicio().ConsultarEmpleados();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }
        [HttpGet("Puestos")]
        public IActionResult GetPuestos()
        {
            List<Puesto> lista = ServicioDao.ObtenerServicio().ConsultarPuestos();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }

        // GET api/<EmpleadoController>/5
        /*
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            EmpleadoDTO empleado = ServicioDao.ObtenerServicio().ConsultarEmpleadoDTOCompleto(id);
            if (empleado != null)
            {
                return Ok(empleado);
            }
            return NoContent();
        }*/

        // POST api/<EmpleadoController>
        [HttpPost]
        public IActionResult Post([FromBody] EmpleadoDTO empleado)
        {
            //dentro de un try catch
            try
            {
                if (empleado == null)
                {
                    return BadRequest("Se esperaba un empleado con todos los datos");
                }
                //if (cliente.) validaciones por si es un objeto valido.
                if (ServicioDao.ObtenerServicio().CargarEmpleado(empleado))
                {
                    return Ok("Empleado registrado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo registrar el empleado");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut]
        public IActionResult Put([FromBody] EmpleadoDTO empleado)
        {
            //dentro de un try catch
            try
            {
                if (empleado == null)
                {
                    return BadRequest("Se esperaba un empleado con todos los datos");
                }
                //if (cliente.) validaciones por si es un objeto valido.
                if (ServicioDao.ObtenerServicio().ActualizarEmpleado(empleado))
                {
                    return Ok("Empleado actualizado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo actualizar el empleado");
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

                if (ServicioDao.ObtenerServicio().EliminarEmpleado(id))
                {
                    return Ok("Empleado eliminado con exito");
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
