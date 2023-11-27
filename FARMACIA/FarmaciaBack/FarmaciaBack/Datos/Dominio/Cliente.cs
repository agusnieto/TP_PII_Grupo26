using FarmaciaBack.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace FarmaciaBack.Datos.Dominio
{
    public class Cliente
    {
        private int id_cliente;
        private string apellido;
        private string nombre;
        private ObraSocial obra_social;
        private Barrio barrio;
        private int dni;
        private bool sexo;
        private long telefono;
        private string email;
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
        public ObraSocial ObraSocial
        {
            get { return obra_social; }
            set { obra_social = value; }
        }
        public Barrio Barrio
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
        public Cliente(int id_cliente, string apellido, string nombre, ObraSocial os, Barrio barrio, int dni, bool sexo)
        {
            IdCliente = id_cliente;
            Apellido = apellido;
            Nombre = nombre;
            ObraSocial = os;
            Barrio = barrio;
            Dni = dni;
            Sexo = sexo;
        }
        public Cliente()
        {

        }

        public override string ToString()
        {
            return IdCliente.ToString() + " " + Apellido + ", " + Nombre;
        }
    }
}
