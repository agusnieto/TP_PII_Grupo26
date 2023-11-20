using System.Data;
using System.Data.SqlClient;

namespace FarmaciaBack.Datos
{
    class HelperDB
    {
        private static HelperDB instancia;
        private SqlConnection cnn;

        private HelperDB()
        {
            cnn = new SqlConnection();//INSERTAR CADENA DE CONEXION
        }

        public static HelperDB ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDB();
            return instancia;
        }
        public DataTable ConsultaSQL(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public int EjecutarSQL(string strSql, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;
        }

        
        public int InsartarSql(string sp, List<Parametro> lst, string pOutput)
        {
            int ok = 0;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sp, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lst != null && lst.Count > 0)
                {
                    foreach (Parametro x in lst)
                    {
                        cmd.Parameters.AddWithValue(x.Clave, x.Valor);
                    }
                }
                //parámetro de salida:
                if (!string.IsNullOrEmpty(pOutput) && !string.IsNullOrWhiteSpace(pOutput))
                {
                    SqlParameter pOut = new SqlParameter();
                    pOut.ParameterName = pOutput;
                    pOut.DbType = DbType.Int32;
                    pOut.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pOut);
                    cmd.ExecuteNonQuery();
                    ok = (int)pOut.Value;
                }
                else
                {
                    ok = cmd.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                ok = 0;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }

            }

            return ok;
        }

    }
}