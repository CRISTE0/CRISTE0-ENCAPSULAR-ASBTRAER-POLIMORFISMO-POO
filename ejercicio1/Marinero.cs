using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Marinero : Tripulante
    {
        private double pesoTotalPescado { get; set; }
        private const double sueldo = 90000;
        private double sueldoTotal { get; set; }
        private double bono { get; set; }

        public Marinero(int _numeroCarnet,int _edad,int _tiempoEnEmpresa,string _nombre,int _telefono,char _sexo,Barco _barco,double _pesoTotalPescado):base(_numeroCarnet,_edad,_tiempoEnEmpresa,_nombre,_telefono,_sexo,_barco)
        {
            pesoTotalPescado = _pesoTotalPescado;
        }

        public void calcularBono()
        {
            if (pesoTotalPescado>=1)
            {
                bono = pesoTotalPescado*0.25;
                sueldoTotal=sueldo+bono;
                Console.WriteLine($"El bono obtenido es: {bono}");

            }
        }


        public override void sueldoT(){
            Console.WriteLine($"{sueldoTotal}");
            
        }
        
        public override void mostrarDato()
        {
            Console.WriteLine($"\nLos datos del marinero son: \n**********************\n{numeroCarnet}\n{edad}\n{tiempoEnEmpresa}\n{nombre}\n{telefono}\n{sexo}\n{barco.nombre}\n{barco.tipo}\n{barco.capacidadPasajeros}\n{barco.capacidadCarga}\n{pesoTotalPescado}\n{sueldo}\n{sueldoTotal}\n{bono}\n**********************\n");
        }
    }

}
