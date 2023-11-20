using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmaciaBack.Datos.Dominio
{
    public class Sede
    {
        private int id;
        private string nombre;
        private Barrio barrio;
        private string calle;
        private int telefono;
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
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

        public Sede(int id, string nombre, Barrio barrio, string calle)
        {
            Id = id;
            Nombre = nombre;
            Barrio = barrio;
            Calle = calle;
        }
        public Sede()
        {

        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
