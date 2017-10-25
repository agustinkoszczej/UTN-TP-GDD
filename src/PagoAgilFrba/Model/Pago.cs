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
        public int sucursal { get; set; }
        public int forma_pago { get; set; }
        public int factura { get; set; }

        public Pago(double _importe, int _id_sucursal, int _id_forma_pago, int _id_factura)
        {
            //this.id = _id;
            //this.fecha = _fecha; -- La obtengo directo de la BD (GETDATE())
            this.importe = _importe;
            this.sucursal = _id_sucursal;
            this.forma_pago = _id_forma_pago;
            this.factura = _id_factura;
        }
    }
}
