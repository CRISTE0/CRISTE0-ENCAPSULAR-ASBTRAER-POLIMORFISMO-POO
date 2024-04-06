using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Vendedor : Empleado
    {
     
        private string matriculaCoche;
        private string marcaCoche;
        private string modeloCoche;
        private string telefonoMovil;
        private string areaVenta;
        private string[] listaClientes;
        private double porcentajeComision;

       
        public Vendedor(string nombre, string apellidos, string dni, string direccion, string telefono, double salario, string matriculaCoche, string marcaCoche, string modeloCoche, string telefonoMovil, string areaVenta, double porcentajeComision) : base(nombre, apellidos, dni, direccion, telefono, salario)
        {
            this.matriculaCoche = matriculaCoche;
            this.marcaCoche = marcaCoche;
            this.modeloCoche = modeloCoche;
            this.telefonoMovil = telefonoMovil;
            this.areaVenta = areaVenta;
            this.porcentajeComision = porcentajeComision;
        }

       
        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Matrícula del coche: {matriculaCoche}");
            Console.WriteLine($"Marca del coche: {marcaCoche}");
            Console.WriteLine($"Modelo del coche: {modeloCoche}");
            Console.WriteLine($"Teléfono móvil: {telefonoMovil}");
            Console.WriteLine($"Área de venta: {areaVenta}");
            Console.WriteLine($"Porcentaje de comisión: {porcentajeComision}%");
            Console.WriteLine("Puesto: Vendedor");
        }

     
        public void DarAltaCliente(string nuevoCliente)
        {
            Console.WriteLine("Cliente dado de alta");
        }

 
        public void DarBajaCliente(string cliente)
        {
            Console.WriteLine("Cliente dado de baja");
        }

        public void CambiarCoche(string nuevaMatricula, string nuevaMarca, string nuevoModelo)
        {
            this.matriculaCoche = nuevaMatricula;
            this.marcaCoche = nuevaMarca;
            this.modeloCoche = nuevoModelo;
        }
    }

}
