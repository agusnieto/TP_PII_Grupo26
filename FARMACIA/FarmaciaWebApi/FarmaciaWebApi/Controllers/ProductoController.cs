﻿using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Servicio.Implementacion;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {   
        [HttpGet("Marcas")]
        public IActionResult GetMarcas() //devuelve un Json y un Codigo OK 200
        {
            List<Marca> lista = ServicioDao.ObtenerServicio().ConsultarMarcas();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }
        [HttpGet("Paises")]
        public IActionResult GetPaises()
        {
            List<Pais> lista = ServicioDao.ObtenerServicio().ConsultarPaises();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }
        [HttpGet("{id}")]
        public IActionResult GetProducto(int id)
        {
            Producto producto = ServicioDao.ObtenerServicio().ConsultarProducto(id);
            if (producto != null)
            {
                return Ok(producto);
            }
            return NoContent();
        }
        [HttpGet("Proveedores")]
        public IActionResult GetProveedores()
        {
            List<Proveedor> lista = ServicioDao.ObtenerServicio().ConsultarProveedores();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }
        [HttpGet("TiposProducto")]
        public IActionResult GetTiposProducto()
        {
            List<TipoProducto> lista = ServicioDao.ObtenerServicio().ConsultarTiposProducto();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }
        [HttpGet("Caracteristicas")]
        public IActionResult GetCaracteristicas()
        {
            List<Caracteristica> lista = ServicioDao.ObtenerServicio().ConsultarCaracteristicas();
            if (lista != null)
            {
                return Ok(lista);
            }
            return NoContent();
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            //dentro de un try catch
            try
            {
                if (producto == null)
                {
                    return BadRequest("Se esperaba un producto completo");
                }
                //if (producto.) validaciones por si es un objeto valido.
                if (ServicioDao.ObtenerServicio().CargarProducto(producto))
                {
                    return Ok("Producto registrado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo registrar el producto");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] Producto producto)
        {
            //dentro de un try catch
            try
            {
                if (producto == null)
                {
                    return BadRequest("Se esperaba un producto completo");
                }
                //if (ValidarProducto(producto))
                //{
                    if (ServicioDao.ObtenerServicio().CargarProducto(producto))
                    {
                        return Ok("Producto registrado con exito");
                    }
                    else
                    {
                        return StatusCode(500, "No se pudo registrar el producto");
                    }
                //}
                /*
                 * 
                   NOMBRE VARCHAR(50),
                   DESCRIPCION VARCHAR(100),
                   ID_CARACTERISTICA INT,
                   ID_T_PRODUCTO INT,
                    ID_MARCA INT,
                    ID_PROVEEDOR INT,
                    ID_PAIS INT,
                    STOCK INT,
                    PRECIO DECIMAL(10,2)
                 */
               
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] int id)
        {
            //dentro de un try catch
            try
            {
                if (id == null)
                {
                    return BadRequest("Se esperaba un identificador de un cliente");
                }
                if (ServicioDao.ObtenerServicio().EliminarProducto(id))
                {
                        return Ok("Producto eliminado con exito");
                }
                else
                {
                    return StatusCode(500, "No se pudo eliminar el producto");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, "Error interno, intente nuevamente mas tarde");
            }
        }
    }
}
