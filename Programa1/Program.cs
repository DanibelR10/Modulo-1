using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite el segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 != 0)
            {
                double resultado = num1 / num2;
                Console.WriteLine("Total de la division: " + resultado);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
        }
    }
}
