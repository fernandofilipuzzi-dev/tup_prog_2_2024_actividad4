namespace Ejercicio2.Models
{
    class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado)
            : base(lado, lado)
        { }

        public override string ToString()
        {
            return $"Cuadrado- {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }
    }
}
