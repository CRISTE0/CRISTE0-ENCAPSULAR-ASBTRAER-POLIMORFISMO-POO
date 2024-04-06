namespace Punto3
{
    abstract class Vehiculo
    {
        protected string matricula;
        protected int velocidad;

        public Vehiculo(string matricula)
        {
            this.matricula = matricula;
            velocidad = 0;
        }

        public virtual void Acelerar(int incremento)
        {
            velocidad += incremento;
        }

        public override string ToString()
        {
            return $"Matrícula: {matricula}, Velocidad: {velocidad} km/h";
        }
    }
}
