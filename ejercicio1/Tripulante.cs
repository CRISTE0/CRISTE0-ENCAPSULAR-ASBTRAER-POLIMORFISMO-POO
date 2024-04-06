using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio1
{
    public abstract class Tripulante
    {
        protected int numeroCarnet { get; set; }
        protected int edad { get; set; }
        protected int tiempoEnEmpresa { get; set; }
        protected string nombre { get; set; }
        protected int telefono { get; set; }
        protected char sexo { get; set; }
        public Barco barco;

        public Tripulante(int _numeroCarnet, int _edad, int _tiempoEnEmpresa, string _nombre, int _telefono, char _sexo, Barco _barco)
        {
            numeroCarnet = _numeroCarnet;
            edad = _edad;
            tiempoEnEmpresa = _tiempoEnEmpresa;
            nombre = _nombre;
            telefono = _telefono;
            sexo = _sexo;
            barco = _barco;
        }

        public abstract void sueldoT();

        public abstract void mostrarDato();
    }
}
