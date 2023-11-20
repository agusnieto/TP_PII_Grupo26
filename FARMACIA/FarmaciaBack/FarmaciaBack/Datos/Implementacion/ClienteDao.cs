using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmaciaBack.Datos.Implementacion
{
    public class ClienteDao : IClienteDao
    {
        public bool PostCliente(Cliente oCliente)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@NOMBRE", oCliente.Nombre),
                new Parametro("@APELLIDO", oCliente.Apellido),
                new Parametro("@ID_BARRIO", oCliente.Barrio.Id),
                new Parametro("@TELEFONO", oCliente.Telefono),
                new Parametro("@EMAIL", oCliente.Email)
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERT_CLIENTE", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

        public List<Barrio> GetBarrios()
        {
            Barrio barrio;
            List<Barrio> lista = new List<Barrio>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_BARRIOS", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    barrio = new Barrio()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString()
                    };
                    lista.Add(barrio);
                }
            }
            return lista;
        }

        public List<Cliente> GetCliente()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_CLIENTE", new List<Parametro>());
            Cliente cliente;
            List<Cliente> lista = new List<Cliente>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    cliente = new Cliente();
                    lista.Add(cliente);
                }
            }
            return lista;
        }
        public bool PutCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        /*public List<Cliente> GetClientesScreen()
{
   DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_SCREEN_CLIENTES", new List<Parametro>());
   List<Cliente> lista = new List<Cliente>();
   Cliente cliente;
   if (tabla.Rows.Count > 0)
   {
       foreach (DataRow row in tabla.Rows)
       {
           cliente = new Cliente();
           lista.Add(cliente);
       }
   }
   return lista;
}*/
    }
}

