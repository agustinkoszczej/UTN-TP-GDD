using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Item_Factura
    {
        public int id { get; private set; }
        public double monto { get; set; }
        public int cantidad { get; set; }
        public Factura factura { get; set; }
        public bool nuevo { get; set; }

        public Item_Factura(int _id, double _monto, int  _cantidad, Factura _factura)
        {
            this.id = _id;
            this.monto = _monto;
            this.cantidad = _cantidad;
            this.factura = _factura;
            this.nuevo = false;

        }
    }
}
