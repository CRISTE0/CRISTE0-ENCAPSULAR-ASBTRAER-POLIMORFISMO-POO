using ejercicio1;

class Program
{
    public static void Main(string[] args)
    {

        Barco barco = new Barco("RFish", "Pesquero", 15, 200);
        GPS gps = new GPS("234.142", "24.615", "5/04/2024", "13:55", 6);

        Capitan capitan = new Capitan(3252, 33, 4, "Jef", 134226, 'M', barco, 6500,0);
        capitan.calcularBono();
        capitan.sueldoT();
        capitan.mostrarDato();


        JefeFlota jefeFlota = new JefeFlota(232452, 23, 2, "Pol", 73363, 'M', barco, 20, 40);
        jefeFlota.calcularBono();
        jefeFlota.sueldoT();
        jefeFlota.mostrarDato();




        Marinero marinero1 = new Marinero(7546743, 55, 2, "Fred", 633556, 'M', barco, 40);
        marinero1.calcularBono();
        marinero1.sueldoT();
        Marinero marinero2 = new Marinero(634364, 33, 4, "Carl", 633556, 'M', barco, 30);
        marinero2.calcularBono();
        marinero2.sueldoT();
        Marinero marinero3 = new Marinero(92384, 24, 2, "Jonh", 633556, 'M', barco, 40);
        marinero3.calcularBono();
        marinero3.sueldoT();
        Marinero marinero4 = new Marinero(25592, 63, 4, "Samy", 633556, 'F', barco, 34);
        marinero4.calcularBono();
        marinero4.sueldoT();
        Marinero marinero5 = new Marinero(2593, 23, 5, "Sam", 633556, 'M', barco, 20);
        marinero5.calcularBono();
        marinero5.sueldoT();
        Marinero marinero6 = new Marinero(9924, 51, 6, "Leo", 633556, 'M', barco, 10);
        marinero6.calcularBono();
        marinero6.sueldoT();
        Marinero marinero7 = new Marinero(42552, 23, 1, "Pepe", 633556, 'M', barco, 10);
        marinero7.calcularBono();
        marinero7.sueldoT();

        List<dynamic> marineros = new List<dynamic>();

        marineros.Add(marinero1);
        marineros.Add(marinero2);
        marineros.Add(marinero3);
        marineros.Add(marinero4);
        marineros.Add(marinero5);
        marineros.Add(marinero6);
        marineros.Add(marinero7);


        foreach (var item in marineros)
        {
            item.mostrarDato();
        }


    }

}