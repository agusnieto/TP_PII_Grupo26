using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Proveedor
    {
        private int id;
        private string nombre;
        private RazonSocial razon;
        private Barrio barrio;
        private string calle;
        private long cuit;
        private long telefono;
        private string email;

        public long Telefono {  get; set; }
        public string Email { get; set; }

        public long Cuit
        {
            get { return cuit; }
            set { cuit = value; }
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

        public RazonSocial Razon
        {
            get { return razon; }
            set { razon = value; }
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

        public Proveedor(int id, string nombre, RazonSocial razon, Barrio barrio)
        {
            Id = id;
            Nombre = nombre;
            Barrio = barrio;
        }
        public Proveedor()
        {

        }

        public override string ToString()
        {
            return Id + "-" + Nombre + " " + Razon;
        }

    }
}
