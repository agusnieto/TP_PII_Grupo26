using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Provincia
    {
        private int id;
        private string nombre;
        private Pais pais;

        public Pais Pais
        {
            get { return pais; }
            set { pais = value; }
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

        public Provincia()
        {

        }
        public Provincia(int id, string nombre, Pais pais)
        {
            Id = id;
            Nombre = nombre;
            Pais = pais;
        }
    }
}
