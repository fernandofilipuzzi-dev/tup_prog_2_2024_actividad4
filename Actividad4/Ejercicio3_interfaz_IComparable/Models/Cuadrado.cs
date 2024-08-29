

namespace Ejercicio3.Models
{
    class Cuadrado : Rectangulo
    {

        public Cuadrado(double lado)
            : base(lado, lado)
        { }

        public override string ToString()
        {
            return $"{"Cuadrado",15}  {CalcularArea().ToString("0.00")}";
        }
    }
}
