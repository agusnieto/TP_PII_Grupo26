using FarmaciaBack.Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public EmpleadoDTO Empleado { get; set; }
        public ClienteDTO Cliente { get; set; }
        public FormaPago FormaPago { get; set; }
        public Sede Sede { get; set; }
        public FormaEnvio Envio { get; set; }
        public List<DetalleFactura> DetalleFactura { get; set; }
        public List<DetalleServicio> DetalleServicio { get; set; }


        public double TotalProductos()
        {
            double total = 0;
            foreach (DetalleFactura det in DetalleFactura)
            {
                total += det.Precio * det.Cantidad;
            }
            return total;

        }

        public double TotalServicios()
        {
            double total = 0;
            foreach (DetalleServicio det in DetalleServicio)
            {
                total += det.Precio + det.Atencion;
            }
            return total;

        }

        public double Total() { return TotalServicios() + TotalProductos(); }

        public void AgregarDetalleServicio(DetalleServicio detalle)
        {
            DetalleServicio.Add(detalle);
        }
        public void AgregarDetalleFactura(DetalleFactura detalle)
        {
            DetalleFactura.Add(detalle);
        }
        public void QuitarDetalleServicio(int id)
        {
            DetalleServicio.RemoveAt(id);
        }
        public void QuitarDetalleFactura(int id)
        {
            DetalleFactura.RemoveAt(id);
        }

    }
}
