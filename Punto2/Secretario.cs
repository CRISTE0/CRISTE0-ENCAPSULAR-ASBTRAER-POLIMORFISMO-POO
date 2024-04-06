using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Secretario : Empleado
    {
     
        private string despacho;
        private string numeroFax;

       
        public Secretario(string nombre, string apellidos, string dni, string direccion, string telefono, double salario, string despacho, string numeroFax) : base(nombre, apellidos, dni, direccion, telefono, salario)
        {
            this.despacho = despacho;
            this.numeroFax = numeroFax;
        }


        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Despacho: {despacho}");
            Console.WriteLine($"Número de Fax: {numeroFax}");
            Console.WriteLine("Puesto: Secretario");
        }
    }
}
