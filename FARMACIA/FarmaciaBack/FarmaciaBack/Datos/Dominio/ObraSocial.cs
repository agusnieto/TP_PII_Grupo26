using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class ObraSocial
    {
        private int id;
        private string nombre;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public ObraSocial(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Nombre = nombre;
        }
        public ObraSocial()
        {

        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
