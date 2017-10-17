using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Forma_Pago
    {
        public int id { get; private set; }
        public string descripcion { get; set; }

        public Forma_Pago(int _id, string _descripcion)
        {
            this.id = _id;
            this.descripcion = _descripcion;
        }
    }
}
