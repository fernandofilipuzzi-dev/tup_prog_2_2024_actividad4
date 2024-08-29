
namespace Ejercicio1.Models
{
    class Rectangulo:IFigura
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double CalcularArea()
        {
            return Largo*Ancho;
        }

        public override string ToString()
        {
            return $"Rectángulo {CalcularArea().ToString("0.00")}";
        }
    }
}
