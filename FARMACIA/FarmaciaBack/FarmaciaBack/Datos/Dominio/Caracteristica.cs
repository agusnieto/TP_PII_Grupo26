using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Caracteristica
    {
        private int id;
        private string detalle;
        private TipoCaracteristica tipo_carac;
        private Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public TipoCaracteristica Tio_carac
        {
            get { return tipo_carac; }
            set { tipo_carac = value; }
        }
        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Caracteristica()
        {

        }
    }
}
