using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Barco
    {
        public string nombre{get;set;}
        public string tipo{get;set;}
        public int capacidadPasajeros{get;set;}
        public int capacidadCarga{get;set;}

        public Barco(string _nombre,string _tipo,int _capacidadPasajeros,int _capacidadCarga)
        {
            nombre=_nombre;
            tipo=_tipo;
            capacidadPasajeros=_capacidadPasajeros;
            capacidadCarga=_capacidadCarga;
        }

        public void mostrarDatos(){
            Console.WriteLine($"Los datos del barco son: {nombre}\n{tipo} \n {capacidadPasajeros} \n {capacidadCarga}\n");
        }

        
    }
}
