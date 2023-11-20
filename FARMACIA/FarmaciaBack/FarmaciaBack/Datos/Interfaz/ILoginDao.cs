using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Interfaz
{
    public interface ILoginDao
    {
        bool Login(string usuario, string clave);
    }
}
