using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;


namespace FarmaciaBack.Datos
{

    public class AccesoDatos
    {
        private static AccesoDatos instancia;
        private SqlConnection cnn;
        private AccesoDatos()
        {
            cnn = new SqlConnection(@"Data Source=172.16.10.196;Initial Catalog=VITAFARMA;User ID=alumno1w1;Password=alumno1w1");
        }

        public static AccesoDatos ObtenerInstancia() 
        {
            if(instancia == null)
            {
                instancia = new AccesoDatos();
            }
            return instancia;
        }
        public int Logeo(string sp, List<Parametro> parametros)
        {
            int ret = 0;
            try
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = sp;
                if(parametros != null)
                {
                    foreach(Parametro param in parametros)
                    {
                        comando.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }
                                
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    ret = 1;
                }
            }
            catch (Exception)
            {
                ret = -1;
            }
            finally
            {
                cnn.Close();
            }
            return ret;
        }
    }
}
