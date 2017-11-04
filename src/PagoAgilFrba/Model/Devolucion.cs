using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Devolucion
    {
        public int id { get; private set; }
        public string motivo { get; set; }
        public double monto { get; set; }
        public Factura factura { get; set; }
        public DateTime fecha { get; set; }

        public Devolucion(int _id, string _motivo, double _monto, Factura _factura, DateTime _fecha)
        {
            this.id = _id;
            this.motivo = _motivo;
            this.monto = _monto;
            this.factura = _factura;
            this.fecha = _fecha;
        }
    }
}
