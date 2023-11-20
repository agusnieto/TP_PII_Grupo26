using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Servicio.Interfaz
{
    public interface IServicio
    {
        //Cliente
        bool CargarCliente(Cliente oCliente);
        bool ActualizarCliente(Cliente oCliente);
        bool EliminarCliente(int id);
        List<Barrio> ConsultarBarrios();
        List<Cliente> ConsultarClientes();
        Cliente ConsultarCliente(int id);
        //List<Cliente> GetClientesScreen();

        //Producto
        Producto ConsultaProducto(int id);
        List<TipoProducto> ConsultarTipoProducto();
        List<Marca> ConsultarMarcas();
        List<Proveedor> ConsultarProveedores();
        List<Pais> ConsultarPaises();
        bool CargarProducto(Producto oProducto);
        bool ActualizarProducto(Producto producto);
        bool EliminarProducto(int id);
    }
}
