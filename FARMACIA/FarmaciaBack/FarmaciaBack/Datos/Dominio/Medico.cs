using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Medico
    {
        private int id;
        private int matricula;
        private string apellido;
        private string nombre;
        private ObraSocial obra_social;
        private Sede sede;
        private DateTime fecha_ingreso;
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
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
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
        public Sede Sede
        {
            get { return sede; }
            set { sede = value; }
        }
        public DateTime FechaIngreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }
        public Medico(int id, string apellido, string nombre, int matricula, ObraSocial os, DateTime fecha_ingr)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            Matricula = matricula;
            ObraSocial = os;
            FechaIngreso = fecha_ingr;
        }
        public Medico()
        {

        }

        public override string ToString()
        {
            return Id + "-" + Apellido + ", " + Nombre;
        }
    }
}
