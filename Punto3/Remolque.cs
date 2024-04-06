namespace Punto3
{
    internal class Remolque
    {
        private int peso;

        public Remolque(int peso)
        {
            this.peso = peso;
        }

        public override string ToString()
        {
            return $"Peso del remolque: {peso} kg";
        }
    }


    class DemasiadoRapidoException : Exception
    {
        public DemasiadoRapidoException(string mensaje) : base(mensaje)
        {
            Console.WriteLine("Vas demasiodo rapido");
        }
    }
}
