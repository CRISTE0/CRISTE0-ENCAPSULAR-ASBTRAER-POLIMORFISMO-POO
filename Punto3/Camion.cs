namespace Punto3
{
    internal class Camion : Vehiculo
    {
        private Remolque remolque;

        public Camion(string matricula) : base(matricula)
        {
            remolque = null;
        }

        public void PonRemolque(Remolque nuevoRemolque)
        {
            remolque = nuevoRemolque;
        }

        public void QuitaRemolque()
        {
            remolque = null;
        }

        public override void Acelerar(int incremento)
        {
            if (remolque != null && velocidad + incremento > 100)
            {
                throw new DemasiadoRapidoException("El camión no puede acelerar tanto con el remolque");
            }
            base.Acelerar(incremento);
        }

        public override string ToString()
        {
            if (remolque != null)
            {
                return base.ToString() + $", {remolque}";
            }
            else
            {
                return base.ToString();
            }
        }
    }

}
