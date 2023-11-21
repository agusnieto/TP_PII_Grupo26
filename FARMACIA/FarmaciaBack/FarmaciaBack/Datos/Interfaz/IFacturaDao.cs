using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Interfaz
{
    public interface IFacturaDao
    {

        List<EmpleadoDTO> GetEmpleados(int sede);
        EmpleadoDTO GetEmpleado(int id);
        List<ClienteDTO> GetClientes();
        ClienteDTO GetCliente(int id);
        List<FormaPago> GetFormasPago();
        List<Sede> GetSedes();
        List<FormaEnvio> GetFormasEnvio();
        bool PostFactura(Factura factura);
        public List<ServicioDTO> GetServicioDTO();
        Producto GetProduto(int id);

    }
}
