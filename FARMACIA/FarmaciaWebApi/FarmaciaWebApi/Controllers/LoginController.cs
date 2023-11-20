using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaWebApi.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]

    public class LoginController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult PostLogin([FromBody] LoginModel loginModel)
        {
            bool aux = ServicioDao.ObtenerServicio().Login(loginModel);
            if (aux)
            {
                return Ok("Login exitoso");
            }
            else
            {
                return NotFound("Usuario o contraseña incorrecto");
            }
        }
    }
}

