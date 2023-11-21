using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
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
        Producto ConsultarProducto(int id);
        List<TipoProducto> ConsultarTiposProducto();
        List<Caracteristica> ConsultarCaracteristicas();
        List<Marca> ConsultarMarcas();
        List<Proveedor> ConsultarProveedores();
        List<Pais> ConsultarPaises();
        bool CargarProducto(Producto oProducto);
        bool ActualizarProducto(Producto producto);
        bool EliminarProducto(int id);

        //Login
        bool Login(LoginModel login);

        //Factura
        List<EmpleadoDTO> ConsultarEmpleados(int sede);
        EmpleadoDTO ConsultarEmpleado(int id);
        List<ClienteDTO> ConsultarClientesDTO();
        ClienteDTO ConsultarClienteDTO(int id);
        List<FormaPago> ConsultarFormasPago();
        List<Sede> ConsultarSedes();
        List<FormaEnvio> ConsultarFormasEnvio();
        bool ActualizarMaestroDetalle(Factura factura);
        List<ServicioDTO> GetServicioDTO();
        Producto GetProduto(int id);
        bool CargarFactura(Factura factura);

        //MEDICO        
        List<ObraSocial> ConsultarObrasSociales();
        List<Medico> ConsultarMedicos();
        Medico ConsultarMedico(int id);
        bool ActualizarMedico(MedicoDTO medico);
        bool CargarMedico(MedicoDTO medico);
        bool EliminarMedico(int id);
        public List<MedicoDTO> ConsultarMedicosDTO();
        public MedicoDTO ConsultarMedicoDTO(int id);


    }
}
