using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Empresa
    {
        public int id { get; set; }
        public string cuit { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public bool habilitada { get; set; }
        public List<Rubro> rubros;

        public Empresa(int _id, string _cuit, string _nombre, string _direccion, bool _habilitada)
        {
            this.id = _id;
            this.cuit = _cuit;
            this.nombre = _nombre;
            this.direccion = _direccion;
            this.habilitada = _habilitada;
            this.rubros = new List<Rubro>();
        }

        //Alta Empresa (altok perroh)
        public Empresa(string _cuit, string _nombre, string _direccion, List <Rubro> _rubros)
        {
            this.cuit = _cuit;
            this.nombre = _nombre;
            this.direccion = _direccion;
            this.rubros = _rubros;
        }
    }
}
