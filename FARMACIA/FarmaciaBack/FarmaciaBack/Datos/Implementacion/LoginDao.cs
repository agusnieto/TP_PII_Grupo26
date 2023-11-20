using FarmaciaBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Implementacion
{
    internal class LoginDao : ILoginDao
    {
        public bool Login(string usuario, string clave)
        {
            bool aux = false;
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@USUARIO_INGRESADO", usuario),
                new Parametro("@CLAVE_INGRESADA", usuario)
            };
            if(AccesoDatos.ObtenerInstancia().Logeo("SP_LOGIN", parametros) == 1)
            {
                aux = true;
            }
            return aux;
        }
    }
}
