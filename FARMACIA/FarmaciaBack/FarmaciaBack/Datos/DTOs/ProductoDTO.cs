using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.DTOs
{
    public class ProductoDTO
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int tipo_producto;
        private int marca;
        private int proveedor;
        private int pais;
        private int caracteristica;
        private int stock;
        private double precio;

        public int Caracteristica
        {
            get { return caracteristica; }
            set { caracteristica = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public int Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        public int Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int TipoProd
        {
            get { return tipo_producto; }
            set { tipo_producto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public ProductoDTO(int id, string nombre, int marca, int proveedor)
        {
            Id = id;
            Nombre = nombre;
            Marca = marca;
            Proveedor = proveedor;
        }
        public ProductoDTO(int id, string nombre, string descripcion, int caracteristica, int tipo, int marca, int proveedor, int pais, int stock, double precio)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Caracteristica = caracteristica;
            TipoProd = tipo;
            Marca = marca;
            Proveedor = proveedor;
            Pais = pais;
            Stock = stock;
            Precio = precio;
        }

        public ProductoDTO()
        {

        }

        public override string ToString()
        {
            return $"{id} - {Nombre} ";
        }
    }
}
