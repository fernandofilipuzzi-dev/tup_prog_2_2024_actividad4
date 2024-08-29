

namespace Ejercicio1.Models
{
    class Cuadrado : Rectangulo
    {
        public int Largo { get; private set; }
        public int Ancho { get; private set; }

        public Cuadrado(double lado)
            : base(lado, lado)
        { }

        public override string ToString()
        {
            return $"Cuadrado {CalcularArea().ToString("0.00")}";
        }
    }
}
