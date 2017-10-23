using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Factura
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public double total { get; set; }
        public DateTime fecha_venc { get; set; }
        public Empresa empresa { get; set; }
        public Cliente cliente { get; set; }
        public Rendicion rendicion { get; set; }
        public List<Item_Factura> items;
        public bool habilitada { get; set; }

        public Factura(int _id, DateTime _fecha, double _total, DateTime _fecha_venc, Empresa _empresa, Cliente _cliente, Rendicion _rendicion, bool _habilitada)
        {
            this.id = _id;
            this.fecha = _fecha;
            this.total = _total;
            this.fecha_venc = _fecha_venc;
            this.empresa = _empresa;
            this.cliente = _cliente;
            this.rendicion = _rendicion;
            this.items = new List<Item_Factura>();
            this.habilitada = _habilitada;
        }

        public Factura(int _id, DateTime _fecha, double _total, DateTime _fecha_venc, Empresa _empresa, Cliente _cliente, Rendicion _rendicion)
        {
            this.id = _id;
            this.fecha = _fecha;
            this.total = _total;
            this.fecha_venc = _fecha_venc;
            this.empresa = _empresa;
            this.cliente = _cliente;
            this.rendicion = _rendicion;
            this.items = new List<Item_Factura>();
        }
        //Pago
        public Factura(int _id, DateTime _fecha, double _total, DateTime _fecha_venc, Empresa _empresa, Cliente _cliente)
        {
            this.id = _id;
            this.fecha = _fecha;
            this.total = _total;
            this.fecha_venc = _fecha_venc;
            this.empresa = _empresa;
            this.cliente = _cliente;
            this.items = new List<Item_Factura>();
        }
    }
}
