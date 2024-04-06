namespace Punto3
{
    internal class Coche : Vehiculo
    {
        private int numeroPuertas;

        public Coche(string matricula, int numeroPuertas) : base(matricula)
        {
            this.numeroPuertas = numeroPuertas;
        }

        public int NumeroPuertas
        {
            get { return numeroPuertas; }
        }

        public override string ToString()
        {
            return base.ToString() + $", Número de puertas: {numeroPuertas}";
        }
    }
}
