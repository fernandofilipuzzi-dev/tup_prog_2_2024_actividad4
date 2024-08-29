using System;

namespace Ejercicio3.Models
{
    class Circulo:IFigura, IComparable
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
            return $"{"Circulo",15} {CalcularArea().ToString("0.00")}";
        }

        public int CompareTo(object obj) 
        {
            IFigura fig = obj as IFigura;
            if (fig != null)
            {
                return this.CalcularArea().CompareTo(fig.CalcularArea());
            }
            return 1;
        }
    }
}
