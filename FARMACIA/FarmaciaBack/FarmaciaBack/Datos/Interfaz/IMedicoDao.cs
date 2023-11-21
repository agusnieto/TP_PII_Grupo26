using FarmaciaBack.Datos.Dominio;
using FarmaciaBack.Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Interfaz
{
    public interface IMedicoDao
    {
        List<Sede> GetSedes();//
        List<ObraSocial> GetObrasSociales();//
        List<Medico> GetMedicos();//
        Medico GetMedico(int id);//
        bool PutMedico(Medico medico);//
        bool PostMedico(Medico medico);//
        bool DeleteMedico(int id);//
        public List<MedicoDTO> GetMedicosDTO();
        public MedicoDTO GetMedicoDTO(int id);
        
    }
}
