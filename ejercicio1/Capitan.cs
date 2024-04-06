using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Capitan : Tripulante
    {
        private int horasExperticia { get; set; }
        private const int sueldo = 4500000;
        private float sueldoTotal { get; set; }
        private float bono { get; set; }

        public Capitan(int _numeroCarnet, int _edad, int _tiempoEnEmpresa, string _nombre, int _telefono, char _sexo, Barco _barco, int _horasExperticia, float _bono) : base(_numeroCarnet, _edad, _tiempoEnEmpresa, _nombre, _telefono, _sexo, _barco)
        {
            horasExperticia = _horasExperticia;
            bono = _bono;
        }

        public void calcularBono()
        {
            if (horasExperticia >= 5000 && horasExperticia < 150000)
            {

                bono = sueldo * 20 / 100;
                sueldoTotal = sueldo + bono;
                Console.WriteLine($"El bono obtenido del capitan es: {bono}");

            }
            else if (horasExperticia >= 150000 && horasExperticia < 300000)
            {
                bono = sueldo * 40 / 100;
                sueldoTotal = sueldo + bono;
                Console.WriteLine($"El bono obtenido del capitan es: {bono}");

            }
            else if (horasExperticia > 300000)
            {
                bono = sueldo * 75 / 100;
                sueldoTotal = sueldo + bono;
                Console.WriteLine($"El bono obtenido del capitan es: {bono}");

            }
        }


        public override void sueldoT()
        {
            Console.WriteLine($"{sueldoTotal}");
        }

        public override void mostrarDato()
        {
            Console.WriteLine($"\nLos datos del capitan son: \n**********************\n{numeroCarnet}\n{edad}\n{tiempoEnEmpresa}\n{nombre}\n{telefono}\n{sexo}\n{barco.nombre}\n{barco.tipo}\n{barco.capacidadPasajeros}\n{barco.capacidadCarga}\n{horasExperticia}\n{sueldo}\n{sueldoTotal}\n{bono}\n**********************\n");
        }

    }
}

//  Método propio para calcular el bono de la siguiente manera:
// ▪ Si las horas de experticia es mayor igual a 5000 y menor a 150000 tendrá un bono del
// 20%.
// ▪ Si las horas de experticia es mayor igual a 150000 y menor a 300000 tendrá un bono del
// 40%. Y si es mayor a 300000 será un 75% de bono
// ▪ Su sueldo total se calculará: sueldo más bono.