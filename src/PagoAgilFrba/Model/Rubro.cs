﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Sucursal
    {
        public int id { get; private set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int cod_postal { get; set; }
        public bool habilitada { get; set; }

        public Sucursal(int _id, string _nombre, string _direccion, int _cod_postal, bool _habilitada)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.direccion = _direccion;
            this.cod_postal = _cod_postal;
            this.habilitada = _habilitada;
        }
    }
}
