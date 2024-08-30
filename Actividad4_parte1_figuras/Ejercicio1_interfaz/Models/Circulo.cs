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

        public double CalcularPerimetro()
        {
            return 2* Math.PI * Radio;
        }

        public override string ToString()
        {
            return $"Circulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }
    }
}
