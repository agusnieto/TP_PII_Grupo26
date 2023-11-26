using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Interfaz
{
    public interface IProveedorDao
    {
        List<RazonSocial> GetRazonesSociales();
        List<ProveedorDTO> GetProveedoresDTO();
        ProveedorDTO GetProveedorDTO(int id);
        List<Proveedor> GetProveedores();
        Proveedor GetProveedor(int id);
        bool PostProveedor(ProveedorDTO proveedor);
        bool PutProveedor(ProveedorDTO proveedor);
        bool DeleteProveedor(int id);
    }
}
