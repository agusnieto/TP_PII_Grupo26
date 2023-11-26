using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmaciaBack.Datos.DTOs;


namespace FarmaciaBack.Datos.Interfaz
{
    public interface IProductoDao
    {
        Producto GetProducto(int id);
        List<TipoProducto> GetTipoProducto();
        List<Marca> GetMarcas();
        List<Proveedor> GetProveedores();
        List<Pais> GetPaises();
        List<Caracteristica> GetCaracteristica();
        bool PostProducto(ProductoDTO oProducto);
        bool PutProducto(ProductoDTO producto);
        bool DeleteProducto(int id);
        List<ProductoDTO> GetProductos();
        List<Producto> ControlStock(string nombre);
    }
}
