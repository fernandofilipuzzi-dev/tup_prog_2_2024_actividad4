
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
        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        public override string ToString()
        {
            return $"Rectangulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }

       
    }
}
