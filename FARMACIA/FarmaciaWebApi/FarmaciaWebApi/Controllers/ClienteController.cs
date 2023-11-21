﻿using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Servicio.Implementacion;
using FarmaciaBack.Servicio.Interfaz;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet("Barrios")]
        public IActionResult GetBarrio() // IActionResult devuelve un Json y un Codigo OK 200
        {
            List<Barrio> lista = ServicioDao.ObtenerServicio().ConsultarBarrios();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetClientes() // IActionResult devuelve un Json y un Codigo OK 200
        {
            List<Cliente> lista = ServicioDao.ObtenerServicio().ConsultarClientes();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id) // IActionResult devuelve un Json y un Codigo OK 200
        {
            Cliente cliente = ServicioDao.ObtenerServicio().ConsultarCliente(id);
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return NoContent();
        }

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            //dentro de un try catch
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Se esperaba un cliente con todos los datos");
                }
                //if (cliente.) validaciones por si es un objeto valido.
                if (ServicioDao.ObtenerServicio().CargarCliente(cliente))
                {
                    return Ok("Cliente registrado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo registrar el cliente");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            //dentro de un try catch
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Se esperaba un cliente con todos los datos");
                }
                //if (cliente.) validaciones por si es un objeto valido.
                if (ServicioDao.ObtenerServicio().ActualizarCliente(cliente))
                {
                    return Ok("Cliente registrado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo registrar el cliente");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] int id)
        {
            //dentro de un try catch
            try
            {
                if (id == null)
                {
                    return BadRequest("Se esperaba un identificador de un cliente");
                }
                /*if (ValidarDatos())
                {
                ID_CLIENTE INT,
                NOMBRE VARCHAR(50),
                APELLIDO VARCHAR(50),
                ID_OBRASOCIAL INT,
                ID_BARRIO INT,
                DNI BIGINT,
                TELEFONO BIGINT,
                EMAIL VARCHAR(50),
                SEXO BIT
                }*/
                if (ServicioDao.ObtenerServicio().ConsultarCliente(id) != null)
                {
                    if (ServicioDao.ObtenerServicio().EliminarCliente(id))
                    {
                        return Ok("Cliente eliminado con exito");
                    }
                    else
                    {
                        return StatusCode(500, "No se pudo eliminar el cliente");

                    }
                }
                else
                {
                    return NotFound("No hay clientes con ese identificador asociado");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }

        /*private bool ValidarDatos(ClienteDTO cliente)
        {
            private bool ValidarDatos()
            {
                int n = 0;
                if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    n = 1;
                }
                else
                {
                    foreach (char c in txtApellido.Text)
                    {
                        if (c <= 31 && c > 32 || c < 65 && c > 90 || c < 97 && c > 122)
                        {
                            n = 1;
                        }
                    }
                }
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    n = 2;
                }
                else
                {
                    foreach (char c in txtNombre.Text)
                    {
                        if (c <= 31 && c > 32 || c < 65 && c > 90 || c < 97 && c > 122)
                        {
                            n = 2;
                        }
                    }
                }
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    n = 3;
                }
                else
                {
                    foreach (char c in txtEmail.Text)
                    {
                        if (c <= 31 && c >= 33 || c <= 45 && c >= 47 || c < 64 && c > 90 || c < 97 && c > 122)
                        {
                            n = 3;
                        }
                    }
                }
                if (string.IsNullOrEmpty(txtTelefono.Text) || !int.TryParse(txtTelefono.Text, out _))
                {
                    n = 4;
                }
                if (string.IsNullOrEmpty(cboBarrio.Text))
                {
                    n = 5;
                }
                switch (n)
                {

                }*/
    }
}
    


