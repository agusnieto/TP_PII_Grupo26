using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using FarmaciaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Implementacion
{
    public class MedicoDao : IMedicoDao
    {
        public bool DeleteMedico(int id)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID", id),
            };

            if (HelperDB.ObtenerInstancia().EjecutarSQL("SP_DELETE_MEDICO", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }

        public Medico GetMedico(int id)
        {
            Medico medico = null;
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_MEDICO", new List<Parametro>()
            {
                new Parametro("@ID", id)
            });

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    medico = new Medico()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Matricula = Convert.ToInt32(row.ItemArray[1]),
                        Apellido = row.ItemArray[2].ToString(),
                        Nombre = row.ItemArray[3].ToString(),
                        ObraSocial = new ObraSocial(Convert.ToInt32(row.ItemArray[4]), row.ItemArray[5].ToString()),
                        Sede = new Sede()
                        {
                            Id = Convert.ToInt32(row.ItemArray[6]),
                            Nombre = row.ItemArray[7].ToString()
                        },
                        FechaIngreso = Convert.ToDateTime(row.ItemArray[8]),
                        Telefono = Convert.ToInt64(row.ItemArray[9]),
                        Email = row.ItemArray[10].ToString()
                    };
                }
            }
            return medico;
        }
        public List<MedicoDTO> GetMedicosDTO()
        {
            MedicoDTO medico = null;
            List<MedicoDTO> lista = new List<MedicoDTO>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_MEDICOS", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    medico = new MedicoDTO()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        NombreCompleto = row.ItemArray[2].ToString() + ", " + row.ItemArray[3].ToString()
                    };
                    lista.Add(medico);
                }
            }
            return lista;
        }
        public MedicoDTO GetMedicoDTO(int id)
        {
            MedicoDTO medico = null;

            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_MEDICOS", new List<Parametro>()
            {
                new Parametro("@ID", id)
            });

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    medico = new MedicoDTO()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        NombreCompleto = row.ItemArray[2].ToString() + ", " + row.ItemArray[3].ToString()
                    };

                }
            }
            return medico;
        }

        public List<Medico> GetMedicos()
        {
            Medico medico;
            List<Medico> lista = new List<Medico>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_MEDICOS", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    medico = new Medico()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Matricula = Convert.ToInt32(row.ItemArray[1]),
                        Apellido = row.ItemArray[2].ToString(),
                        Nombre = row.ItemArray[3].ToString(),
                        ObraSocial = new ObraSocial(Convert.ToInt32(row.ItemArray[4]), row.ItemArray[5].ToString()),
                        Sede = new Sede()
                        {
                            Id = Convert.ToInt32(row.ItemArray[6]),
                            Nombre = row.ItemArray[7].ToString()
                        },
                        FechaIngreso = Convert.ToDateTime(row.ItemArray[8]),
                        Telefono = Convert.ToInt64(row.ItemArray[9]),
                        Email = row.ItemArray[10].ToString()
                    };
                    lista.Add(medico);
                }
            }
            return lista;
        }
        public List<ObraSocial> GetObrasSociales()
        {
            ObraSocial os;
            List<ObraSocial> lista = new List<ObraSocial>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_OBRAS_SOCIALES", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    os = new ObraSocial()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString()
                    };
                    lista.Add(os);
                }
            }
            return lista;
        }


        public List<Sede> GetSedes()
        {
            Sede sede;
            List<Sede> lista = new List<Sede>();
            DataTable tabla = HelperDB.ObtenerInstancia().ConsultaSQL("SP_GET_SEDES", new List<Parametro>());

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    sede = new Sede()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Nombre = row.ItemArray[1].ToString()
                    };
                    lista.Add(sede);
                }
            }
            return lista;
        }


        public bool PostMedico(MedicoDTO medico)
        {
            bool ok = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@MATRICULA", medico.Matricula),
                new Parametro("@APELLIDO", medico.Apellido),
                new Parametro("@NOMBRE", medico.Nombre),
                new Parametro("@OBRA_SOCIAL", medico.ObraSocial),
                new Parametro("@SEDE", medico.Sede),
                new Parametro("@TELEFONO", medico.Telefono),
                new Parametro("@EMAIL", medico.Email)
            };
            int aux = HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERT_MEDICO", parametros);
            if (aux == 1)
            {
                ok = true;
            }
            return ok;
        }

        public bool PutMedico(MedicoDTO medico)
        {
            bool ok = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@ID", medico.Id),                
                new Parametro("@APELLIDO", medico.Apellido),
                new Parametro("@NOMBRE", medico.Nombre),
                new Parametro("@OBRA_SOCIAL", medico.ObraSocial),
                new Parametro("@SEDE", medico.Sede),                
                new Parametro("@TELEFONO", medico.Telefono),
                new Parametro("@EMAIL", medico.Email)
            };
            int aux = HelperDB.ObtenerInstancia().EjecutarSQL("SP_UPDATE_MEDICO", parametros);
            if (aux == 1)
            {
                ok = true;
            }
            return ok;
        }


    }
}

