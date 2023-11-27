using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
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
        public bool PostCliente(ClienteDTO oCliente)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@NOMBRE", oCliente.Nombre),
                new Parametro("@APELLIDO", oCliente.Apellido),
                new Parametro("@OBRA_SOCIAL", oCliente.ObraSocial),
                new Parametro("@BARRIO", oCliente.Barrio),
                new Parametro("@DNI", oCliente.Dni),
                new Parametro("@TELEFONO", oCliente.Telefono),
                new Parametro("@EMAIL", oCliente.Email),
                new Parametro("@SEXO", oCliente.Sexo)
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

        public Cliente GetCliente(int id)
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_CLIENTE", new List<Parametro>() { new Parametro("@ID", id) });
            Cliente cliente = null;

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    cliente = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Apellido = row.ItemArray[2].ToString(),
                        ObraSocial = new ObraSocial()
                        {
                            Id = Convert.ToInt32(row.ItemArray[3]),
                            Nombre = row.ItemArray[4].ToString()
                        },
                        Barrio = new Barrio()
                        {
                            Id = Convert.ToInt32(row.ItemArray[5]),
                            Nombre = row.ItemArray[6].ToString()
                        },
                        Dni = Convert.ToInt32(row.ItemArray[7])
                    };
                    cliente.Telefono = Convert.ToInt64(row.ItemArray[8]);
                    cliente.Email = row.ItemArray[9].ToString();
                    cliente.Sexo = Convert.ToBoolean(row.ItemArray[10]);
                };                         
            }
            return cliente;
        }
            
        
    public List<Cliente> GetClientes()
    {
        DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_CLIENTES", new List<Parametro>());
        Cliente cliente;
        List<Cliente> lista = new List<Cliente>();

        if (tabla.Rows.Count > 0)
        {
            foreach (DataRow row in tabla.Rows)
            {
                    cliente = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(row.ItemArray[0].ToString()),
                        Nombre = row.ItemArray[1].ToString(),
                        Apellido = row.ItemArray[2].ToString(),
                        ObraSocial = new ObraSocial()
                        {
                            Id = Convert.ToInt32(row.ItemArray[3]),
                            Nombre = row.ItemArray[4].ToString()
                        },
                        Barrio = new Barrio()
                        {
                            Id = Convert.ToInt32(row.ItemArray[5]),
                            Nombre = row.ItemArray[6].ToString()
                        },
                        Dni = Convert.ToInt32(row.ItemArray[7])
                    };
                    cliente.Telefono = Convert.ToInt64(row.ItemArray[8]);
                    cliente.Email = row.ItemArray[9].ToString();
                    cliente.Sexo = Convert.ToBoolean(row.ItemArray[10]);

                    lista.Add(cliente);
            }
        }
        return lista;
    }
    public bool PutCliente(ClienteDTO oCliente)
    {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID", oCliente.IdCliente),
                new Parametro("@NOMBRE", oCliente.Nombre),
                new Parametro("@APELLIDO", oCliente.Apellido),
                new Parametro("@OBRA_SOCIAL", oCliente.ObraSocial),
                new Parametro("@BARRIO", oCliente.Barrio),
                new Parametro("@DNI", oCliente.Dni),
                new Parametro("@TELEFONO", oCliente.Telefono),
                new Parametro("@EMAIL", oCliente.Email),
                new Parametro("@SEXO", oCliente.Sexo)
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_UPDATE_CLIENTE", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

    public bool DeleteCliente(int id)
    {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID", id),
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_DELETE_CLIENTE", parametros) == 1)
            {
                aux = true;
            }
            return aux;
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

