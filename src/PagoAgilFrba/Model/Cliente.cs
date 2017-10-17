using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Cliente
    {
        public int id { get; private set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public UInt32 dni { get; set; }
        public string mail { get; set; }
        public UInt32 telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string cod_postal { get; set; }
        public bool habilitado { get; set; }

        public Cliente(int _id, string _nombre, string _apellido, UInt32 _dni, DateTime _fechaNac, string _direccion, string _cod_postal, bool _habilitado)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.dni = _dni;
            this.fecha_nacimiento = _fechaNac;
            this.direccion = _direccion;
            this.cod_postal = _cod_postal;
            this.habilitado = _habilitado;
        }
    }
}
