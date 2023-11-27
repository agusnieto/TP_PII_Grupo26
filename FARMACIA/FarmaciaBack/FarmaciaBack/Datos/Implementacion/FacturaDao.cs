using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmaciaBack.Datos.Implementacion
{
    public class FacturaDao : IFacturaDao
    {
        public bool PostFactura(Factura factura)
        {
            bool resultado = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@LEGAJO", factura.Empleado.Legajo),
                new Parametro("@CLIENTE", factura.Cliente.IdCliente),
                new Parametro("@PAGO", factura.FormaPago.Id),
                new Parametro("@SEDE", factura.Sede.Id),
                new Parametro("@ENVIO", factura.Envio.Id)
            };
            int nro_factura = HelperDB.ObtenerInstancia().InsartarSql("SP_INSERT_FACTURAS", parametros, "@FACTURA");

            if (nro_factura > 0)
            {
                int auxser = 0;
                int auxfact = 0;

                factura.NroFactura = nro_factura;

                if (factura.DetalleServicio != null)
                {
                    foreach (DetalleServicio ds in factura.DetalleServicio)
                    {
                        List<Parametro> detalleS = new List<Parametro>()
                    {
                    new Parametro("@FACTURA", factura.NroFactura),
                    new Parametro("@MEDICO", ds.Medico.Id),
                    new Parametro("@SERVICIO", ds.Servicio.Id),
                    new Parametro("@PRECIO", ds.Precio),
                    new Parametro("@ATENCION", ds.Atencion),
                    new Parametro("@DESCUENTO", 0)   //REVISAR SI DESCUENTO ESTA BIEN ACA O VA EN FACTURA           
                    };
                        auxser += HelperDB.ObtenerInstancia().InsartarSql("SP_INSERT_DET_SERVICIO", detalleS, "");
                    }
                }
                if (factura.DetalleFactura != null)
                {
                    foreach (DetalleFactura df in factura.DetalleFactura)
                    {
                        List<Parametro> detalleF = new List<Parametro>()
                    {
                    new Parametro("@FACTURA", factura.NroFactura),
                    new Parametro("@PRODUCTO", df.Producto.Id),
                    new Parametro("@CANTIDAD", df.Cantidad),
                    new Parametro("@PRECIO", df.Precio)
                    };
                        auxfact += HelperDB.ObtenerInstancia().InsartarSql("SP_INSERT_DET_FACTURA", detalleF, "");
                    }
                }

                if (auxser == factura.DetalleServicio.Count && auxfact == factura.DetalleFactura.Count)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        public List<FormaPago> GetFormasPago()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_FORMA_PAGO", new List<Parametro>());
            FormaPago pago;
            List<FormaPago> lista = new List<FormaPago>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    pago = new FormaPago()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Forma = row.ItemArray[1].ToString()
                    };
                    lista.Add(pago);
                }
            }
            return lista;
        }

        public List<FormaEnvio> GetFormasEnvio()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_FORMA_ENVIO", new List<Parametro>());

            FormaEnvio envio;
            List<FormaEnvio> lista = new List<FormaEnvio>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    envio = new FormaEnvio(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString());
                    lista.Add(envio);
                }
            }
            return lista;
        }

        public List<EmpleadoDTO> GetEmpleados(int sede)
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_EMPLEADOS_X_SEDE", new List<Parametro>() {
                new Parametro("@SEDE", sede)
            });

            List<EmpleadoDTO> lista = new List<EmpleadoDTO>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    EmpleadoDTO empleado = new EmpleadoDTO()
                    {
                        Legajo = Convert.ToInt32(row["LEGAJO"]),
                        Nombre = row["NOMBRE"].ToString(),
                        Apellido = row["APELLIDO"].ToString(),
                        NombreCompleto = row["APELLIDO"].ToString() + ", " + row["NOMBRE"].ToString()
                    };
                    lista.Add(empleado);
                }
            }
            return lista;
        }

        public EmpleadoDTO GetEmpleado(int id)
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_EMPLEADO", new List<Parametro>()
            {
                new Parametro("ID", id)
            }
            );

            EmpleadoDTO empleado = null;
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    empleado = new EmpleadoDTO()
                    {
                        Legajo = Convert.ToInt32(row.ItemArray[0]),
                        NombreCompleto = row.ItemArray[1].ToString() + ", " + row.ItemArray[2].ToString()
                    };
                }
            }
            return empleado;
        }

        public List<ClienteDTO> GetClientes()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_CLIENTES", new List<Parametro>());

            ClienteDTO cliente;
            List<ClienteDTO> lista = new List<ClienteDTO>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    cliente = new ClienteDTO()
                    {
                        IdCliente = Convert.ToInt32(row.ItemArray[0]),
                        NombreCompleto = row.ItemArray[1].ToString() + ", " + row.ItemArray[2].ToString()
                    };
                    lista.Add(cliente);
                }
            }
            return lista;
        }

        public ClienteDTO GetCliente(int id)
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_CLIENTE", new List<Parametro>()
            {
                new Parametro("ID", id)
            }
            );

            ClienteDTO cliente = null;
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    cliente = new ClienteDTO()
                    {
                        IdCliente = Convert.ToInt32(row.ItemArray[0]),
                        NombreCompleto = row.ItemArray[1].ToString() + ", " + row.ItemArray[2].ToString()
                    };
                }
            }
            return cliente;
        }

        public List<FormaPago> GetFormasmasPago()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_FORMAS_PAGO", new List<Parametro>());

            FormaPago pago;
            List<FormaPago> lista = new List<FormaPago>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    pago = new FormaPago()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Forma = row.ItemArray[1].ToString()
                    };
                    lista.Add(pago);
                }
            }
            return lista;
        }

        public List<Sede> GetSedes()
        {
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_SEDES", new List<Parametro>());

            Sede sede;
            List<Sede> lista = new List<Sede>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    sede = new Sede()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString()
                    };
                    lista.Add(sede);
                }
            }
            return lista;
        }

        public Producto GetProduto(int id)
        {
            
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_FACTURACION_PRODUCTO", new List<Parametro>()
            {
                new Parametro("@Id", id)
            });

            Producto producto = null;
            
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    producto = new Producto()
                    {
                        Id = Convert.ToInt32(row["ID_PRODUCTO"]),
                        Nombre = row["NOMBRE"].ToString(),
                        Precio = (float)Convert.ToDecimal(row["PRECIO"].ToString()),
                        TipoProducto = new TipoProducto() { Id = Convert.ToInt32(row["ID_T_PRODUCTO"]), Tipo = row["TIPO"].ToString() }
                    };                    
                }
            }
            return producto;
        }
        public List<ServicioDTO> GetServicioDTO()
        {
            ServicioDTO servicio;
            List<ServicioDTO> lista = new List<ServicioDTO>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_SERVICIOS", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    servicio = new ServicioDTO()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString()
                    };
                    lista.Add(servicio);
                }
            }
            return lista;
        }
    }
}
