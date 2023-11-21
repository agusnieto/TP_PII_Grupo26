﻿using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        // GET: api/<MedicoController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Medico> lista = ServicioDao.ObtenerServicio().ConsultarMedicos();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NotFound("No hay Medicos cargados");
        }
        [HttpGet("MedicoDTO")]
        public IActionResult GetMedicoDTO()
        {
            List<MedicoDTO> lista = ServicioDao.ObtenerServicio().ConsultarMedicosDTO();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NotFound("No hay Medicos cargados");
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
        [HttpGet("ObrasSociales")]
        public IActionResult GetObrasSociales()
        {
            List<ObraSocial> lista = ServicioDao.ObtenerServicio().ConsultarObrasSociales();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NotFound("No hay Obras Sociales cargadas");
        }

        // GET api/<MedicoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Medico medico = ServicioDao.ObtenerServicio().ConsultarMedico(id);
            if (medico != null)
            {
                return Ok(medico);
            }
            return NotFound("No hay Medicos cargados");
        }

        // POST api/<MedicoController>
        [HttpPost]
        public IActionResult Post([FromBody] Medico value)
        {
            if (value != null)
            {
                if (ServicioDao.ObtenerServicio().CargarMedico(value))
                {
                    return Ok("El Medico fue cargado correctamente");
                }
            }

            return BadRequest("Se espera un Medico no nulo");

        }

        // PUT api/<MedicoController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Medico value)
        {
            if (value != null)
            {
                if (ServicioDao.ObtenerServicio().ActualizarMedico(value))
                {
                    return Ok("El Medico fue cargado correctamente");
                }
            }

            return BadRequest("Se espera un Medico no nulo");
        }

        // DELETE api/<MedicoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                if (ServicioDao.ObtenerServicio().EliminarMedico(id))
                {
                    return Ok("El Medico ah sido eliminado correctamente");
                }
            }
            return BadRequest();
        }
    }
}
