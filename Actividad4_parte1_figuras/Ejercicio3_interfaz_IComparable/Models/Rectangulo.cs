using System;

namespace Ejercicio3.Models
{
    class Rectangulo: IFigura, IComparable
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

        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        public override string ToString()
        {
            return $"{"Rectangulo",15} - {CalcularArea(),10:f2} - {CalcularPerimetro(),10:f2}";
        }

        public int CompareTo(object obj)
        {
            IFigura fig = obj as IFigura;
            if (fig != null)
            {
                double areaEsta = this.CalcularArea();
                double areaFig = fig.CalcularArea();
                return areaEsta.CompareTo(areaFig);

                //de forma equivalente
                //return this.CalcularArea().CompareTo(fig.CalcularArea());
            }
            return 1;
        }
    }
}
