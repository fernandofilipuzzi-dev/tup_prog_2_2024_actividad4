using System;

namespace Ejercicio4.Models
{
    abstract public class Figura:IFigura, IComparable
    {
        abstract public double CalcularArea();

       abstract public double CalcularPerimetro();

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
