using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese las coordenadas del punto A (x1, y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las coordenadas del punto B (x2, y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las coordenadas del punto C (x3, y3):");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(x1, y1, x2, y2, x3, y3);

            Perimetro perimetro = new Perimetro();
            double perimetroTriangulo = perimetro.CalcularPerimetro(triangulo);
            Console.WriteLine("El perímetro del triángulo es: " + perimetroTriangulo);

            Area area = new Area();
            double areaTriangulo = area.CalcularArea(triangulo, perimetroTriangulo);
            Console.WriteLine("El área del triángulo es: " + areaTriangulo);
        }
    }
}