using FarmaciaBack.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace FarmaciaBack.Datos.DTOs
{
    public class ClienteDTO
    {
        private int id_cliente;
        private string apellido;
        private string nombre;
        private int obra_social;
        private int barrio;
        private int dni;
        private bool sexo;
        private long telefono;
        private string email;
        private string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int IdCliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int ObraSocial
        {
            get { return obra_social; }
            set { obra_social = value; }
        }
        public int Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public bool Sexo//1 Feminino, 0 Masculino
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public ClienteDTO(int id_cliente, string apellido, string nombre, int os, int barrio, int dni, bool sexo)
        {
            IdCliente = id_cliente;
            Apellido = apellido;
            Nombre = nombre;
            ObraSocial = os;
            Barrio = barrio;
            Dni = dni;
            Sexo = sexo;
        }
        public ClienteDTO()
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nId del Cliente: " + IdCliente + "\nNombre: " + Nombre + "\nApellido: " + Apellido;
        }
    }
}
