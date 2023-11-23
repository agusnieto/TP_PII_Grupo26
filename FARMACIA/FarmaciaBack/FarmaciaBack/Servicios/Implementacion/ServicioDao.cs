using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
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
        private IFacturaDao facturaDao;
        private IMedicoDao medicoDao;
        private ServicioDao()
        {
            clienteDao = new ClienteDao();
            productoDao = new ProductoDao();
            loginDao = new LoginDao();
            facturaDao = new FacturaDao();
            medicoDao = new MedicoDao();
        }
        public static ServicioDao ObtenerServicio()
        {
            if (instancia == null)
            {
                instancia = new ServicioDao();
            }
            return instancia;
        }

        public bool ActualizarCliente(Cliente oCliente)
        {
            return clienteDao.PostCliente(oCliente);
        }

        public bool ActualizarProducto(ProductoDTO producto)
        {
            return productoDao.PutProducto(producto);
        }


        public bool CargarCliente(Cliente oCliente)
        {
            return clienteDao.PostCliente(oCliente);
        }

        public bool CargarProducto(ProductoDTO oProducto)
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

        public List<ProductoDTO> ListarProducto()
        {
            return productoDao.ListarProductos();
        }
        public bool Login(LoginModel login)
        {
            return loginDao.Login(login);
        }

        public List<EmpleadoDTO> ConsultarEmpleados(int sede)
        {
            return facturaDao.GetEmpleados(sede);
        }

        public EmpleadoDTO ConsultarEmpleado(int id)
        {
            return facturaDao.GetEmpleado(id);
        }

        public List<FormaPago> ConsultarFormasPago()
        {
            return facturaDao.GetFormasPago();
        }

        public List<Sede> ConsultarSedes()
        {
            return facturaDao.GetSedes();
        }

        public List<FormaEnvio> ConsultarFormasEnvio()
        {
            return facturaDao.GetFormasEnvio();
        }

        public bool CargarMaestroDetalle(Factura factura)
        {
            return facturaDao.PostFactura(factura);
        }

        public List<ObraSocial> ConsultarObrasSociales()
        {
            return medicoDao.GetObrasSociales();
        }

        public List<Medico> ConsultarMedicos()
        {
            return medicoDao.GetMedicos(); ;
        }

        public Medico ConsultarMedico(int id)
        {
            return medicoDao.GetMedico(id);
        }

        public bool CargarMedico(MedicoDTO medico)
        {
            return medicoDao.PostMedico(medico);
        }

        public bool ActualizarMedico(MedicoDTO medico)
        {
            return medicoDao.PutMedico(medico);
        }

        public bool EliminarMedico(int id)
        {
            return medicoDao.DeleteMedico(id);
        }

        public List<ClienteDTO> ConsultarClientesDTO()
        {
            return facturaDao.GetClientes();
        }

        public ClienteDTO ConsultarClienteDTO(int id)
        {
            return facturaDao.GetCliente(id);
        }

        public bool ActualizarMaestroDetalle(Factura factura)
        {
            throw new NotImplementedException();
        }

        public List<MedicoDTO> ConsultarMedicosDTO()
        {
            return medicoDao.GetMedicosDTO();
        }

        public MedicoDTO ConsultarMedicoDTO(int id)
        {
            return medicoDao.GetMedicoDTO(id);
        }

        public List<ServicioDTO> GetServicioDTO()
        {
            return facturaDao.GetServicioDTO();
        }

        public Producto GetProduto(int id)
        {
            return facturaDao.GetProduto(id);
        }
        public bool CargarFactura(Factura factura)
        {
            return facturaDao.PostFactura(factura);
        }
    }
}
