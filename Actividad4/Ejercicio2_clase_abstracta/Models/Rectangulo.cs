

namespace Ejercicio2.Models
{
    class Rectangulo:Figura
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        override public double CalcularArea()
        {
            return Largo*Ancho;
        }

        public override string ToString()
        {
            return $"{"Rectángulo",10} {CalcularArea().ToString("0.00")}";
        }
    }
}
