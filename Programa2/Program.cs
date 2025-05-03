using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el primer número: ");
            double Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite el segundo número: ");
            double Numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = Numero1 * Numero2;
            Console.WriteLine("El total del resultado es: " + resultado);
        }
    }
}
