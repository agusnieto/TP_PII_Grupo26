using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Implementacion
{
    public class ProveedorDao : IProveedorDao
    {
        public bool DeleteProveedor(int id)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID", id),
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_DELETE_PROVEEDOR", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

        public Proveedor GetProveedor(int id)
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_PROVEEDOR", new List<Parametro>()
            {
                new Parametro("@ID", id)
            });
            Proveedor proveedor = new Proveedor();
            //List<Proveedor> lista = new List<Proveedor>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    proveedor = new Proveedor()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Razon = new RazonSocial(Convert.ToInt32(row.ItemArray[2]), row.ItemArray[3].ToString()),
                        Barrio = new Barrio(Convert.ToInt32(row.ItemArray[4]), row.ItemArray[5].ToString(), new Provincia()),
                        Calle = row.ItemArray[6].ToString(),
                        Cuit = Convert.ToInt32(row.ItemArray[7].ToString())
                    };
                    if (row.ItemArray[8].Equals(null))
                    {
                        proveedor.Telefono = 0;
                    }
                    else
                    {
                        proveedor.Telefono = Convert.ToInt64(row.ItemArray[8]);
                    }
                    if (row.ItemArray[9].Equals(null))
                    {
                        proveedor.Email = string.Empty;
                    }
                    else
                    {
                        proveedor.Email = row.ItemArray[9].ToString();
                    }
                }

            }
            return proveedor;
        }

        public ProveedorDTO GetProveedorDTO(int id)
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_PROVEEDORES", new List<Parametro>());
            ProveedorDTO proveedor = new ProveedorDTO();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    proveedor = new ProveedorDTO()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        RazonSocial = Convert.ToInt32(row.ItemArray[2]),
                        Barrio = Convert.ToInt32(row.ItemArray[4]),
                        Calle = row.ItemArray[6].ToString(),
                        Cuit = Convert.ToInt32(row.ItemArray[7].ToString())
                    };
                    if (row.ItemArray[8].Equals(null))
                    {
                        proveedor.Telefono = 0;
                    }
                    else
                    {
                        proveedor.Telefono = Convert.ToInt64(row.ItemArray[8]);
                    }
                    if (row.ItemArray[9].Equals(null))
                    {
                        proveedor.Email = string.Empty;
                    }
                    else
                    {
                        proveedor.Email = row.ItemArray[9].ToString();
                    }
                }

            }
            return proveedor;
        }

        public List<Proveedor> GetProveedores()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_PROVEEDORES", new List<Parametro>());
            Proveedor proveedor;
            List<Proveedor> lista = new List<Proveedor>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    proveedor = new Proveedor()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Razon = new RazonSocial(Convert.ToInt32(row.ItemArray[2]), row.ItemArray[3].ToString()),
                        Barrio = new Barrio(Convert.ToInt32(row.ItemArray[4]), row.ItemArray[5].ToString(), new Provincia()),
                        Calle = row.ItemArray[6].ToString(),
                        Cuit = Convert.ToInt64(row.ItemArray[7].ToString())
                    };
                    if (row.ItemArray[8].Equals(null))
                    {
                        proveedor.Telefono = 0;
                    }
                    else
                    {
                        proveedor.Telefono = Convert.ToInt64(row.ItemArray[8]);
                    }
                    if (row.ItemArray[9].Equals(null))
                    {
                        proveedor.Email = string.Empty;
                    }
                    else
                    {
                        proveedor.Email = row.ItemArray[9].ToString();
                    }
                    lista.Add(proveedor);
                }

            }
            return lista;
        }

        public List<ProveedorDTO> GetProveedoresDTO()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_PROVEEDORES", new List<Parametro>());
            ProveedorDTO proveedor;
            List<ProveedorDTO> lista = new List<ProveedorDTO>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    proveedor = new ProveedorDTO()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        RazonSocial = Convert.ToInt32(row.ItemArray[2]),
                        Barrio = Convert.ToInt32(row.ItemArray[4]),
                        Calle = row.ItemArray[6].ToString(),
                        Cuit = Convert.ToInt64(row.ItemArray[7].ToString())
                    };

                    if (row.ItemArray[8].Equals(null))
                    {
                        proveedor.Telefono = 0;
                    }
                    else
                    {
                        proveedor.Telefono = Convert.ToInt64(row.ItemArray[8]);
                    }
                    if (row.ItemArray[9].Equals(null))
                    {
                        proveedor.Email = string.Empty;
                    }
                    else
                    {
                        proveedor.Email = row.ItemArray[9].ToString();
                    }

                    lista.Add(proveedor);
                }

            }
            return lista;
        }

        public List<RazonSocial> GetRazonesSociales()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_RAZON_SOCIAL", new List<Parametro>());
            RazonSocial razon;
            List<RazonSocial> lista = new List<RazonSocial>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    razon = new RazonSocial()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                    };
                    lista.Add(razon);
                }

            }
            return lista;
        }

        public bool PostProveedor(ProveedorDTO proveedor)
        {
            bool aux = false;
            int resultado = HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERT_PROVEEDOR", new List<Parametro>()
            {
                new Parametro("@NOMBRE", proveedor.Nombre),
                new Parametro("@RAZON", proveedor.RazonSocial),
                new Parametro("@BARRIO", proveedor.Barrio),
                new Parametro("@CALLE", proveedor.Calle),
                new Parametro("@CUIT", proveedor.Cuit),
                new Parametro("@TELEFONO", proveedor.Telefono),
                new Parametro("@EMAIL", proveedor.Email)
            }
            );

            if (resultado == 1)
            {
                aux = true;
            }

            return aux;
        }

        public bool PutProveedor(ProveedorDTO proveedor)
        {
            bool aux = false;
            int resultado = HelperDB.ObtenerInstancia().EjecutarSQL("SP_UPDATE_PROVEEDOR", new List<Parametro>()
            {
                new Parametro("@ID", proveedor.Id),
                new Parametro("@NOMBRE", proveedor.Nombre),
                new Parametro("@RAZON", proveedor.RazonSocial),
                new Parametro("@BARRIO", proveedor.Barrio),
                new Parametro("@CALLE", proveedor.Calle),
                new Parametro("@CUIT", proveedor.Cuit),
                new Parametro("@TELEFONO", proveedor.Telefono),
                new Parametro("@EMAIL", proveedor.Email)
            }
            );

            if (resultado == 1)
            {
                aux = true;
            }

            return aux;
        }
    }
}
