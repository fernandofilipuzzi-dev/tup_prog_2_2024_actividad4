using System;


namespace Ejercicio4.Models
{
    class Circulo:Figura
    {
        public double Radio { get; private set; }
      
        public Circulo(double radio)
        {
            Radio = radio;
        }

        override public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        override public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string ToString()
        {
            return "Circulo";
        }
    }
}
