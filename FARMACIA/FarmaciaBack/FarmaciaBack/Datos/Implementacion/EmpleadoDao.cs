using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Implementacion
{
    public class EmpleadoDao : IEmpleadoDao
    {
        public bool DeleteEmpleado(int id)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID", id),
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_DELETE_EMPLEADO", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

        public Empleado GetEmpleado(int id)
        {
            Empleado empleado = new Empleado();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_EMPLEADOS", new List<Parametro>()
            {
                new Parametro("@ID", id)
            });

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    empleado = new Empleado()
                    {
                        Legajo = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Apellido = row.ItemArray[2].ToString(),
                        Puesto = new Puesto(Convert.ToInt32(row.ItemArray[3]), row.ItemArray[4].ToString()),
                        Sede = new Sede
                        {
                            Id = Convert.ToInt32(row.ItemArray[5]),
                            Nombre = row.ItemArray[6].ToString()
                        },
                        Sueldo = Convert.ToDouble(row.ItemArray[7]),
                        Fecha_ingreso = Convert.ToDateTime(row.ItemArray[8]),

                    };
                    if (row.ItemArray[10].Equals(null))
                    {
                        empleado.Telefono = 0;
                    }
                    else
                    {
                        empleado.Telefono = Convert.ToInt64(row.ItemArray[10]);
                    }
                    if (row["EMAIL"].Equals(null))
                    {
                        empleado.Email = string.Empty;
                    }
                    else
                    {
                        empleado.Email = row["EMAIL"].ToString();
                    }
                }
            }
            return empleado;
        }
        /*
        public EmpleadoDTO GetEmpleadoDTO(int id)
        {
            EmpleadoDTO empleado = new EmpleadoDTO();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_EMPLEADOS", new List<Parametro>()
            {
                new Parametro("@LEGAJO", id)
            });

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    empleado = new EmpleadoDTO()
                    {
                        Legajo = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Apellido = row.ItemArray[2].ToString(),
                        Puesto = Convert.ToInt32(row.ItemArray[3]),
                        Sede = Convert.ToInt32(row.ItemArray[5]),
                        Sueldo = Convert.ToDouble(row.ItemArray[7]),
                        FechaIngreso = Convert.ToDateTime(row.ItemArray[8])                  
                                              
                    };
                    if (row.ItemArray[10].Equals(null))
                    {
                        empleado.Telefono = 0;
                    }
                    else
                    {
                        empleado.Telefono = Convert.ToInt64(row.ItemArray[10]);
                    }
                    if (row.ItemArray[11].Equals(null))
                    {
                        empleado.Email = string.Empty;
                    }
                    else
                    {
                        empleado.Email = row.ItemArray[9].ToString();
                    }
                }
            }
            return empleado;
        }*/

        public List<Empleado> GetEmpleados()
        {
            Empleado empleado = new Empleado();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_EMPLEADOS", new List<Parametro>());
            List<Empleado> lista = new List<Empleado>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    empleado = new Empleado()
                    {
                        Legajo = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Apellido = row.ItemArray[2].ToString(),
                        Puesto = new Puesto(Convert.ToInt32(row.ItemArray[3]), row.ItemArray[4].ToString()),
                        Sede = new Sede
                        {
                            Id = Convert.ToInt32(row.ItemArray[5]),
                            Nombre = row.ItemArray[6].ToString()
                        },
                        Sueldo = Convert.ToDouble(row.ItemArray[7]),
                        Fecha_ingreso = Convert.ToDateTime(row.ItemArray[8])
                    };
                    if (row.ItemArray[10].Equals(null))
                    {
                        empleado.Telefono = 0;
                    }
                    else
                    {
                        empleado.Telefono = Convert.ToInt64(row.ItemArray[10]);
                    }
                    if (row["EMAIL"].Equals(null))
                    {
                        empleado.Email = string.Empty;
                    }
                    else
                    {
                        empleado.Email = row["EMAIL"].ToString();
                    }
                    lista.Add(empleado);
                }
            }
            return lista;
        }

        public List<EmpleadoDTO> GetEmpleadosDTO()
        {
            EmpleadoDTO empleado = new EmpleadoDTO();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_EMPLEADOs", new List<Parametro>());
            List<EmpleadoDTO> lista = new List<EmpleadoDTO>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    empleado = new EmpleadoDTO()
                    {
                        Legajo = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString(),
                        Apellido = row.ItemArray[2].ToString(),
                        Puesto = Convert.ToInt32(row.ItemArray[3]),
                        Sede = Convert.ToInt32(row.ItemArray[5]),
                        Sueldo = Convert.ToDouble(row.ItemArray[7]),
                        FechaIngreso = Convert.ToDateTime(row.ItemArray[8])
                    };
                    if (row.ItemArray[10].Equals(null))
                    {
                        empleado.Telefono = 0;
                    }
                    else
                    {
                        empleado.Telefono = Convert.ToInt64(row.ItemArray[10]);
                    }
                    if (row["EMAIL"].Equals(null))
                    {
                        empleado.Email = string.Empty;
                    }
                    else
                    {
                        empleado.Email = row["EMAIL"].ToString();
                    }
                    lista.Add(empleado);
                }
            }
            return lista;
        }

        public List<Puesto> GetPuestos()
        {
            Puesto puesto;
            List<Puesto> lista = new List<Puesto>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_PUESTOS", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    puesto = new Puesto()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Descripcion = row.ItemArray[1].ToString()
                    };
                    lista.Add(puesto);
                }
            }
            return lista;
        }

        public bool PostEmpleado(EmpleadoDTO empleado)
        {
            bool aux = false;
            int resultado = HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERT_EMPLEADO", new List<Parametro>()
            {
                new Parametro("@NOMBRE", empleado.Nombre),
                new Parametro("@APELLIDO", empleado.Apellido),
                new Parametro("@PUESTO", empleado.Puesto),
                new Parametro("@SEDE", empleado.Sede),
                new Parametro("@SUELDO", empleado.Sueldo),
                new Parametro("@TELEFONO", empleado.Telefono),
                new Parametro("@EMAIL", empleado.Email)
            });
            if (resultado == 1)
            {
                aux = true;
            }
            return aux;
        }

        public bool PutEmpleado(EmpleadoDTO empleado)
        {
            bool aux = false;
            int resultado = HelperDB.ObtenerInstancia().EjecutarSQL("SP_UPDATE_EMPLEADO", new List<Parametro>()
            {
                new Parametro("@ID", empleado.Legajo),
                new Parametro("@NOMBRE", empleado.Nombre),
                new Parametro("@APELLIDO", empleado.Apellido),
                new Parametro("@PUESTO", empleado.Puesto),
                new Parametro("@SEDE", empleado.Sede),
                new Parametro("@SUELDO", empleado.Sueldo),
                new Parametro("@TELEFONO", empleado.Telefono),
                new Parametro("@EMAIL", empleado.Email)
            });
            if (resultado == 1)
            {
                aux = true;
            }
            return aux;
        }
    }
}
