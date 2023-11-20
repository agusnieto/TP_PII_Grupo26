using FarmaciaBack.Datos.Implementacion;
using FarmaciaBack.Datos.Interfaz;
using FarmaciaBack.Dominio;
using FarmaciaBack.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Servicio.Implementacion
{
    public class Servicio : IServicio
    {
        private static Servicio instancia;
        private IClienteDAO clienteDAO;
        private IProveedorDAO proveedorDAO;
        private IEmpleadoDAO empleadoDAO;
        private Servicio()
        {
            clienteDAO = new ClienteDAO();
            proveedorDAO = new ProveedorDAO();
        }
        public static Servicio ObtenerIntancia()
        {
            if (instancia.Equals(null))
            {
                instancia = new Servicio();
            }
            return instancia;
        }
        //Cliente
        public bool CargarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaOS> ConsultarCategoriaOS()
        {
            return clienteDAO.GetCategoriaOS();
        }

        public List<CondicionIva> ConsultarCondicionIva()
        {
            return clienteDAO.GetCondicionIva();
        }

        public List<ObraSocial> ConsultarObraSocial()
        {
            return clienteDAO.GetObraSocial();
        }

        //Proveedor
        public List<TipoProveedor> ConsultarTipoProveedor()
        {
            return proveedorDAO.GetTipoProveedor();
        }

        public List<Transporte> ConsultarTransporte()
        {
            return proveedorDAO.GetTransporte();
        }
        public bool CargarProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        //Empleado
        public bool CargarEmpleado(Empleado empleado)
        {
            return empleadoDAO.PostEmpleado(empleado);
        }
        public List<Sucursal> ConsultarSucursal()
        {
            return empleadoDAO.GetSucursal();
        }

    }
}
