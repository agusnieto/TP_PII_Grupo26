using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmaciaBack.Datos.Interfaz
{
    public interface IClienteDao
    {
        bool PostCliente(Cliente oCliente);
        bool PutCliente(Cliente cliente);
        bool DeleteCliente(int id);
        List<Barrio> GetBarrios();
        List<Cliente> GetCliente();
        //List<Cliente> GetClientesScreen();
    }
}
