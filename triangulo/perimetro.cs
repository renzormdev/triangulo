using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    internal class Perimetro
    {
        public double CalcularPerimetro(Triangulo t)
        {
            double ladoAB = Math.Sqrt(Math.Pow(t.x2 - t.x1, 2) + Math.Pow(t.y2 - t.y1, 2));
            double ladoBC = Math.Sqrt(Math.Pow(t.x3 - t.x2, 2) + Math.Pow(t.y3 - t.y2, 2));
            double ladoCA = Math.Sqrt(Math.Pow(t.x3 - t.x1, 2) + Math.Pow(t.y3 - t.y1, 2));

            return ladoAB + ladoBC + ladoCA;
        }
    }
}
