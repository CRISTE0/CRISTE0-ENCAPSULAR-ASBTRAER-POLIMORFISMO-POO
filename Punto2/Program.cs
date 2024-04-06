namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Secretario secretario = new Secretario("Juan", "Perez", "12345678A", "Calle Mayor 1", "123456789", 1500, "Despacho 1", "987654321");

        
            secretario.Imprimir();

            Console.WriteLine();


            Vendedor vendedor = new Vendedor("Maria", "Gomez", "87654321B", "Calle Sol 2", "987654321", 2000, "1234ABC", "Toyota", "Corolla", "666777888", "Ventas Zona Norte", 5);

         
            vendedor.Imprimir();
        }
    }
}
