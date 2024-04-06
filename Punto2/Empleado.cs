using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Empleado
    {
        protected string nombre;
        protected string apellidos;
        protected string dni;
        protected string direccion;
        protected int añosAntiguedad;
        protected string telefono;
        protected double salario;
        protected Empleado supervisor;

     
        public Empleado(string nombre, string apellidos, string dni, string direccion, string telefono, double salario)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.salario = salario;
        }

        
        public virtual void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre} {apellidos}");
            Console.WriteLine($"DNI: {dni}");
            Console.WriteLine($"Dirección: {direccion}");
            Console.WriteLine($"Teléfono: {telefono}");
            Console.WriteLine($"Salario: {salario}");
        }

      
        public void CambiarSupervisor(Empleado nuevoSupervisor)
        {
            this.supervisor = nuevoSupervisor;
        }

        public void IncrementarSalario(double porcentaje)
        {
            salario *= (1 + porcentaje / 100);
        }
    }
}
