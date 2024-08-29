using System;

namespace Ejercicio3.Models
{
    class Rectangulo:IFigura, IComparable
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double CalcularArea()
        {
            return Largo*Ancho;
        }

        public override string ToString()
        {
            return $"{"Rectángulo",15} {CalcularArea().ToString("0.00")}";
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
