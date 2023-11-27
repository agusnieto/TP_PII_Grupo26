using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Empleado
    {
        private int legajo;
        private string apellido;
        private string nombre;
        private Puesto puesto;
        private double sueldo;
        private Sede sede;
        private DateTime fecha_ingreso;
        private bool activo;
        private long telefono;
        private string email;
        private DateTime fecha_baja;
        public DateTime FechaBaja { get; set; }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
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
        public Puesto Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public Sede Sede
        {
            get { return sede; }
            set { sede = value; }
        }
        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
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


        public Empleado(int legajo, string apellido, string nombre, DateTime fecha_ingreso)
        {
            Legajo = legajo;
            Apellido = apellido;
            Nombre = nombre;
            Fecha_ingreso = fecha_ingreso;

        }
        public Empleado()
        {

        }
        public override string ToString()
        {
            return Legajo + "-" + Apellido + ", " + Nombre;
        }
    }
}
