using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Puesto
    {
        private int id;
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Puesto(int id, string desc)
        {
            Id = id;
            Descripcion = desc;
        }
        public Puesto()
        {

        }
        public override string ToString()
        {
            return Descripcion;
        }

    }
}
