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

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string ToString()
        {
            return $"{"Circulo",15} - {CalcularArea(),10:f2} - {CalcularPerimetro(),10:f2}";
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
