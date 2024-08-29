using System;

namespace Ejercicio1.Models
{
    class Circulo:IFigura
    {
        public double Radio { get; private set; }
      
        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override string ToString()
        {
            return $"Circulo {CalcularArea().ToString("0.00")}";
        }
    }
}
