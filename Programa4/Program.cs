using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool esPrimo = true;

            if (num <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
            {
                Console.WriteLine(num + " El numero ingresado es Primo.");
            }
            else
            {
                Console.WriteLine(num + " El numero ingresado no es primo.");
            }
        }
    }
}
