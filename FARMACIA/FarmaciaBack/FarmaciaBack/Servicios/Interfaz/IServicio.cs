using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Servicio.Interfaz
{
    public interface IServicio
    {
        //Cliente
        

        //Producto
        Producto GetProducto(int id);
        List<TipoProducto> GetTipoProducto();
        List<Marca> GetMarcas();
        List<Proveedor> GetProveedores();
        List<Pais> GetPaises();
        bool PostProducto(Producto oProducto);
        bool PostCaracteristica(Caracteristica oCaracteristica);
        bool PutProducto(Producto producto);
        bool DeleteProducto(int id);
    }
}
