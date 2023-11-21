using FarmaciaBack.Datos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class Pedido
    {
        private int id_pedido;
        private DateTime fecha;
        private Proveedor proveedor;
        private FormaPago forma;
        private FormaEnvio envio;
        public int Id
        {
            get { return id_pedido; }
            set { id_pedido = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        public FormaPago FormaPago
        {
            get { return forma; }
            set { forma = value; }
        }
        public FormaEnvio FormaEnvio
        {
            get { return envio; }
            set { envio = value; }
        }
        public Pedido(int id, DateTime fecha, FormaPago pago, FormaEnvio envio)
        {
            Id = id;
            Fecha = fecha;
            FormaPago = pago;
            FormaEnvio = envio;
        }
        public Pedido()
        {

        }
    }
}
