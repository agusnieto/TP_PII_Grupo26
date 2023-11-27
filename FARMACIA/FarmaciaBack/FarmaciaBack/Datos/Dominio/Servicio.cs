using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Servicio
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
        public Servicio(int id, string nombre)
        {
            id = id;
            Nombre = nombre;
        }
        public Servicio()
        {

        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
