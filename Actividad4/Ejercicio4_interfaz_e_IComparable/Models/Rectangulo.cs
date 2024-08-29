namespace Ejercicio4.Models
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

        override public string ToString()
        {
            return "Rectangulo";
        }


    }
}
