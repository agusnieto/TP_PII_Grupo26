using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmaciaBack.Datos.Interfaz
{
    public interface IClienteDao
    {
        bool PostCliente(ClienteDTO oCliente);
        bool PutCliente(ClienteDTO oCliente);
        bool DeleteCliente(int id);
        List<Barrio> GetBarrios();
        List<Cliente> GetClientes();
        Cliente GetCliente(int id);
        //List<Cliente> GetClientesScreen();
    }
}
