

namespace Ejercicio2.Models
{
    class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado)
            : base(lado, lado)
        { }

        public override string ToString()
        {
            return $"{"Cuadrado",10}  {CalcularArea().ToString("0.00")}";
        }
    }
}
