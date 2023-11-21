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
    public class ProductoDao : IProductoDao
    {
        public ProductoDao() { }

        public bool PostProducto(Producto oProducto)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@NOMBRE", oProducto.Nombre),
                new Parametro("@DESCRIPCION", oProducto.Descripcion),
                new Parametro("@TIPO_PRODUCTO", oProducto.TipoProducto.Id),
                new Parametro("@MARCA", oProducto.Marca.Id),
                new Parametro("@PROVEEDOR", oProducto.Proveedor.Id),
                new Parametro("@PAIS", oProducto.Pais.Id),
                new Parametro("@STOCK", oProducto.Stock),
                new Parametro("@PRECIO", oProducto.Precio),
                new Parametro("@CARACTERISTICA", oProducto.Caracteristica.Id)
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
                new Parametro("@ID", id)
            };

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_PRODUCTO", parametros);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    producto = new Producto()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Precio = (float)Convert.ToDecimal(row.ItemArray[2].ToString()),
                        TipoProducto = new TipoProducto() { Id = Convert.ToInt32(row.ItemArray[3]), Tipo = row.ItemArray[4].ToString() }
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
        public List<Caracteristica> GetCaracteristica()
        {
            Caracteristica caracteristica;
            List<Caracteristica> lista = new List<Caracteristica>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_CARACTERISTICA", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    caracteristica = new Caracteristica()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Tipo = row.ItemArray[1].ToString()
                    };
                    lista.Add(caracteristica);
                }
            }
            return lista;
        }

        public bool PutProducto(Producto producto)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID_PRODUCTO", producto.Id),
                new Parametro("@NOMBRE", producto.Nombre),
                new Parametro("@DESCRIPCION", producto.Descripcion),
                new Parametro("@TIPO_PRODUCTO", producto.TipoProducto.Id),
                new Parametro("@MARCA", producto.Marca.Id),
                new Parametro("@PROVEEDOR", producto.Proveedor.Id),
                new Parametro("@PAIS", producto.Pais.Id),
                new Parametro("@STOCK", producto.Stock),
                new Parametro("@PRECIO", producto.Precio)
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_UPDATE_PRODUCTO", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

        public bool DeleteProducto(int id)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID_PRODUCTO", id),
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_DELETE_PRODUCTO", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }
        public List<ProductoDTO> ListarProductos()
        {
            ProductoDTO producto;
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_PRODUCTOS", new List<Parametro>());
            List<ProductoDTO> lista = new List<ProductoDTO>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    producto = new ProductoDTO()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Descripcion = row.ItemArray[2].ToString(),
                        Caracteristica = Convert.ToInt32(row.ItemArray[3]),
                        TipoProducto = Convert.ToInt32(row.ItemArray[4]),
                        Marca = Convert.ToInt32(row.ItemArray[5]),
                        Proveedor = Convert.ToInt32(row.ItemArray[6]),
                        Pais = Convert.ToInt32(row.ItemArray[7]),
                        Stock = Convert.ToInt32(row.ItemArray[8]),
                        Precio = Convert.ToDouble(row.ItemArray[9])
                    };

                    lista.Add(producto);
                }
            }
            return lista;
        }
    }
}
