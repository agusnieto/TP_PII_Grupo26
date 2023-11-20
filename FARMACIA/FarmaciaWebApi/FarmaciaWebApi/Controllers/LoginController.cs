using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/Login
        [HttpGet()]
        public IActionResult GetLogin(string usuario, string clave)
        {
            bool aux = ServicioDao.ObtenerServicio().Login(usuario, clave);
            if (aux)
            {
                return Ok("Login exitoso");
            }
            else
            {
                return NotFound("Usuario o contraseña incorrecto");
            }
        }

        /*// GET api/<LoginController>/usuario/contraseña
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        
    }
}
