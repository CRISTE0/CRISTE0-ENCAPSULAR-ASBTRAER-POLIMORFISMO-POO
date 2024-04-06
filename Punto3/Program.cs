namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Coche coche = new Coche("1234ABC", 4);
                Console.WriteLine(coche);

                Camion camion = new Camion("5678DEF");
                Console.WriteLine(camion);

                Remolque remolque = new Remolque(500);
                camion.PonRemolque(remolque);
                Console.WriteLine(camion);

                camion.Acelerar(90);
                Console.WriteLine(camion);

                camion.Acelerar(20);
            }
            catch (DemasiadoRapidoException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
