using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Rendicion
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public double importe { get; set; }

        public Rendicion(int _id, DateTime _fecha, double _importe)
        {
            this.id = _id;
            this.fecha = _fecha;
            this.importe = _importe;
        }
    }
}
