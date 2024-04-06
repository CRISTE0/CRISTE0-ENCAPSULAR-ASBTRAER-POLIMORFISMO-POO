using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class JefeFlota : Tripulante
    {
        private int pesoPescado { get; set; }
        private int pesoMariscos { get; set; }
        private const float sueldo = 3500000;
        private float sueldoTotal { get; set; }
        private float bonoPescado { get; set; }
        private float bonoMarisco { get; set; }

        public JefeFlota(int _numeroCarnet, int _edad, int _tiempoEnEmpresa, string _nombre, int _telefono, char _sexo, Barco _barco, int _pesoPescado, int _pesoMariscos) : base(_numeroCarnet, _edad, _tiempoEnEmpresa, _nombre, _telefono, _sexo, _barco)
        {
            pesoPescado = _pesoPescado;
            pesoMariscos = _pesoMariscos;
        }

        public void calcularBono()
        {
            bonoPescado = pesoPescado;
            bonoMarisco = pesoMariscos * 2;
            sueldoTotal = bonoPescado + bonoMarisco;
            Console.WriteLine($"El bono obtenido de pescado es: {bonoPescado}");
            Console.WriteLine($"El bono obtenido de marisco es: {bonoMarisco}");

        }
        public override void sueldoT(){
            Console.WriteLine($"{sueldoTotal}");
        }

        public override void mostrarDato()
        {
            Console.WriteLine($"\nLos datos del jefe de flota son:\n**********************\n{numeroCarnet}\n{edad}\n{tiempoEnEmpresa}\n{nombre}\n{telefono}\n{sexo}\n{barco.nombre}\n{barco.tipo}\n{barco.capacidadPasajeros}\n{barco.capacidadCarga}\n{pesoPescado}\n{pesoMariscos}\n{sueldo}\n{sueldoTotal}\n{bonoPescado}\n{bonoMarisco}\n**********************\n");
        }


        

    }
}
