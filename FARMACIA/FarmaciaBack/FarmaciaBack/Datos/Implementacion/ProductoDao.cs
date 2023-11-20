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
    public class ProductoDao : IProductoDao
    {
        public ProductoDao() { }

        public bool PostCaracteristica(Caracteristica oCaracteristica)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@DETALLE", oCaracteristica.Detalle),
                new Parametro("@TIPO_CARACTERISTICA", oCaracteristica.Tio_carac.Id),
                new Parametro("@PRODUCTO", oCaracteristica.Producto.Id)
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERT_CARACTERISTICAS", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

        public bool PostProducto(Producto oProducto)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID_PRODUCTO", oProducto.Id),
                new Parametro("@NOMBRE", oProducto.Nombre),
                new Parametro("@DESCRIPCION", oProducto.Descripcion),
                new Parametro("@TIPO_PRODUCTO", oProducto.TipoProducto.Id),
                new Parametro("@MARCA", oProducto.Marca.Id),
                new Parametro("@PROVEEDOR", oProducto.Proveedor.Id),
                new Parametro("@PAIS", oProducto.Pais.Id),
                new Parametro("@STOCK", oProducto.Stock),
                new Parametro("@PRECIO", oProducto.Precio)
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERT_PRODUCTO", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

        public List<Marca> GetMarcas()
        {
            Marca marca;
            List<Marca> lista = new List<Marca>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_MARCAS", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    marca = new Marca()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString()
                    };
                    lista.Add(marca);
                }
            }
            return lista;
        }

        public List<Pais> GetPaises()
        {
            Pais pais;
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_PAISES", new List<Parametro>());
            List<Pais> lista = new List<Pais>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    pais = new Pais()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString()
                    };
                    lista.Add(pais);
                }
            }
            return lista;
        }

        public Producto GetProducto(int id)
        {
            Producto producto = null;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@id", id)
            };

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_PRODUCTO", parametros);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    producto = new Producto()
                    {
                        Id = Convert.ToInt32(row["ID_PRODUCTO"]),
                        Nombre = row["NOMBRE"].ToString(),
                        Precio = (float)Convert.ToDecimal(row["Precio"].ToString()),
                        TipoProducto = new TipoProducto() { Id = Convert.ToInt32(row["ID_T_PRODUCTO"]), Tipo = row["TIPO"].ToString() }
                    };
                }
            }
            return producto;
        }

        public List<Proveedor> GetProveedores()
        {
            Proveedor proveedor;
            List<Proveedor> lista = new List<Proveedor>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_PROVEEDOR", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    proveedor = new Proveedor()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString()
                    };
                    lista.Add(proveedor);
                }
            }
            return lista;
        }
        public List<TipoProducto> GetTipoProducto()
        {
            TipoProducto tipo;
            List<TipoProducto> lista = new List<TipoProducto>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_TIPO_PRODUCTO", new List<Parametro>());
            
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    tipo = new TipoProducto()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Tipo = row.ItemArray[1].ToString()
                    };
                    lista.Add(tipo);
                }                
            }
            return lista;
        }

        public bool PutProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProducto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
