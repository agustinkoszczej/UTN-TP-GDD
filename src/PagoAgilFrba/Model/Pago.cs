using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Pago
    {
        public int id { get; private set; }
        public DateTime fecha { get; set; }
        public double importe { get; set; }
        public Sucursal sucursal { get; set; }
        public Forma_Pago forma_pago { get; set; }
        public Factura factura { get; set; }

        public Pago(int _id, DateTime _fecha, double _importe, Sucursal _sucursal, Forma_Pago _forma_pago, Factura _factura)
        {
            this.id = _id;
            this.fecha = _fecha;
            this.importe = _importe;
            this.sucursal = _sucursal;
            this.forma_pago = _forma_pago;
            this.factura = _factura;
        }
    }
}
