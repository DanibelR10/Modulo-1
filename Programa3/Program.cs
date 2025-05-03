using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolviendo la ecuación de segundo grado: ax² + bx + c = 0");

            Console.Write("Ingrese el valor Para a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor Para b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor Para c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double determinante = (b * b) - (4 * a * c);

            if (a == 0)
            {
                Console.WriteLine("No es una ecuación cuadrática (a no puede ser cero).");
            }
            else if (determinante > 0)
            {
                double x1 = (-b + Math.Sqrt(determinante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(determinante)) / (2 * a);
                Console.WriteLine("Las soluciones reales son:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (determinante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("La ecuación tiene una única solución real:");
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales (raíces complejas).");
            }
        }
    }
}
