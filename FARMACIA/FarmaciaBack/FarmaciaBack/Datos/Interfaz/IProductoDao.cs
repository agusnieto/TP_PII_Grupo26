﻿using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmaciaBack.Datos.Interfaz
{
    public interface IProductoDao
    {
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