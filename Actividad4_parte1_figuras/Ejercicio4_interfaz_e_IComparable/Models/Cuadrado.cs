
namespace Ejercicio4.Models
{
    class Cuadrado : Rectangulo
    {

        public Cuadrado(double lado): base(lado, lado)
        { }

        override public string ToString()
        {
            return "Cuadrado";
        }
    }
}
