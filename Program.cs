using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wdkwfjkwj
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("numero positivo");
            Console.WriteLine();

            //leer un numero entero positivo y cuando sea negativo, el bucle debe parar.
            //mostrar un mensaje que diga que ha introducido un numero negativo.

            int numero;

            Console.Write("introduzca el numero entero positivo  ");
            numero = int.Parse(Console.ReadLine());


            do
            {
                Console.Write("introduzca un numero entero positivo");
                numero = int.Parse(Console.ReadLine());

            } while (numero > 0);

            Console.WriteLine("ha introducido un numero negativo");

        }
    }
}
