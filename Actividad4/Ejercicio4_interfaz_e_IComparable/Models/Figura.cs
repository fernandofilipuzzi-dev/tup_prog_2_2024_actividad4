using System;


namespace Ejercicio4.Models
{
    abstract class Figura:IFigura, IComparable
    {
        abstract public double CalcularArea();
       
        public int CompareTo(object obj)
        {
            int result = 1;
            if (obj != null && obj is IFigura)
            {
                IFigura fig1 = (IFigura)obj;
                result = this.CalcularArea().CompareTo(fig1.CalcularArea());
            }
            return result;
        }
        
    }
}
