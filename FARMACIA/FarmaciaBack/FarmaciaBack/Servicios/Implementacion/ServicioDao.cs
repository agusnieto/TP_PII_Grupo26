using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.Implementacion;
using FarmaciaBack.Datos.Interfaz;
using FarmaciaBack.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Servicio.Implementacion
{
    public class ServicioDao : IServicio
    {
        private static ServicioDao instancia;
        private IClienteDao clienteDao;
        private IProductoDao productoDao;
        private ILoginDao loginDao;
        private ServicioDao()
        {            
            clienteDao = new ClienteDao();
            productoDao = new ProductoDao();
            loginDao = new LoginDao();
        }
        public static ServicioDao ObtenerServicio()
        {
            if (instancia.Equals(null))
            {
                instancia = new ServicioDao();
            }
            return instancia;
        }

        public bool ActualizarCliente(Cliente oCliente)
        {
            return clienteDao.PostCliente(oCliente);
        }

        public bool ActualizarProducto(Producto producto)
        {
            return productoDao.PutProducto(producto);
        }
              

        public bool CargarCliente(Cliente oCliente)
        {
            return clienteDao.PostCliente(oCliente);
        }

        public bool CargarProducto(Producto oProducto)
        {
            return productoDao.PostProducto(oProducto);
        }

        public Producto ConsultarProducto(int id)
        {
            return productoDao.GetProducto(id);
        }

        public List<Barrio> ConsultarBarrios()
        {
            return clienteDao.GetBarrios();
        }

        public Cliente ConsultarCliente(int id)
        {
            return clienteDao.GetCliente(id);
        }

        public List<Cliente> ConsultarClientes()
        {
            return clienteDao.GetClientes();
        }

        public List<Marca> ConsultarMarcas()
        {
            return productoDao.GetMarcas();
        }

        public List<Pais> ConsultarPaises()
        {
            return productoDao.GetPaises();
        }

        public List<Proveedor> ConsultarProveedores()
        {
            return productoDao.GetProveedores();
        }

        public List<TipoProducto> ConsultarTiposProducto()
        {
            return productoDao.GetTipoProducto();
        }

        public bool EliminarCliente(int id)
        {
            return clienteDao.DeleteCliente(id);
        }

        public bool EliminarProducto(int id)
        {
            return productoDao.DeleteProducto(id);
        }

        public List<Caracteristica> ConsultarCaracteristicas()
        {
            return productoDao.GetCaracteristica();
        }

        public bool Login(LoginModel login)
        {
            return loginDao.Login(login);
        }
    }
}
