using System;

namespace Ejercicio2.Models
{
    abstract class Circulo:Figura
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

        public override string ToString()
        {
            return $"{"Circulo",10} {CalcularArea().ToString("0.00")}";
        }
    }
}
