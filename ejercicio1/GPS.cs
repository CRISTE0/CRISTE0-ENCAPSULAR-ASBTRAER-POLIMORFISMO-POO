using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class GPS
    {
        private string coordenadasX { get; set; }
        private string coordenadasY { get; set; }
        private string fecha { get; set; }
        private string hora { get; set; }
        private int diasTripulado { get; set; }

        public GPS(string _coordenadasX, string _coordenadasY, string _fecha, string _hora, int _diasTripulado)
        {
            coordenadasX = _coordenadasX;
            coordenadasY = _coordenadasY;
            fecha = _fecha;
            hora = _hora;
            diasTripulado = _diasTripulado;
        }
    }
}