using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Barrio
    {
        private int id;
        private string nombre;
        private Provincia provincia;

        public Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
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

        public Barrio(int id, string nombre, Provincia prov)
        {
            Id = id;
            Nombre = nombre;
            Provincia = prov;
        }
        public Barrio()
        { }
        public override string ToString()
        {
            return Nombre;
        }
    }
}

