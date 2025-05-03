using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa6
{
    class Program
    {
        static void Main()
        {
            int a = 0, b = 1, temp;

            Console.WriteLine("Serie Fibonacci del 1 al 50:");
            
            //Se trata de una secuencia infinita de números naturales; a partir del 0 y el 1, se van sumando a pares, de manera que cada número es igual a la suma de sus dos anteriores
            while (b <= 50)
            {
                if (b >= 1)
                {
                    Console.WriteLine(b);
                }
                temp = a + b;
                a = b;
                b = temp;
            }
        }
    }
}
