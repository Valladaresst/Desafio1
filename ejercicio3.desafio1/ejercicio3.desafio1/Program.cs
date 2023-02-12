using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1nand, entrada2nand, entrada1xor, entrada2xor;

            Console.WriteLine("Ingrese el valor de la primera entrada de la compuerta NAND: ");
            entrada1nand = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la segunda entrada de la compuerta NAND: ");
            entrada2nand = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la primera entrada de la compuerta XOR: ");
            entrada1xor = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la segunda entrada de la compuerta XOR: ");
            entrada2xor = Console.ReadLine();

            if (entrada1nand == "F" && entrada2nand == "V" || entrada1nand == "f" && entrada2nand == "v" || entrada1nand == "F" && entrada2nand == "v" || entrada1nand == "f" && entrada2nand == "V")
            {
                Console.WriteLine("El resultado de la compuerta logica es: V");
            }

            if (entrada1nand == "V" && entrada2nand == "F" || entrada1nand == "v" && entrada2nand == "f" || entrada1nand == "V" && entrada2nand == "f" || entrada1nand == "v" && entrada2nand == "F")
            {
                Console.WriteLine("El resultado de la compuerta logica es: V");
            }

            if (entrada1nand == "V" && entrada2nand == "V" || entrada1nand == "v" && entrada2nand == "v" || entrada1nand == "V" && entrada2nand == "v" || entrada1nand == "v" && entrada2nand == "V")
            {
                Console.WriteLine("El resultado de la compuerta logica es: F");
            }

            if (entrada1nand == "F" && entrada2nand == "F" || entrada1nand == "f" && entrada2nand == "f" || entrada1nand == "F" && entrada2nand == "f" || entrada1nand == "f" && entrada2nand == "F")
            {
                Console.WriteLine("El resultado de la compuerta logica es: V");
            }

            if (entrada1xor == "F" && entrada2xor == "F" || entrada1xor == "f" && entrada2xor == "f" || entrada1xor == "F" && entrada2xor == "f" || entrada1xor == "f" && entrada2xor == "F")
            {
                Console.WriteLine("El resultado de la compuerta logica es: F");
            }

            if (entrada1xor == "F" && entrada2xor == "V" || entrada1xor == "f" && entrada2xor == "v" || entrada1xor == "F" && entrada2xor == "v" || entrada1xor == "f" && entrada2xor == "V")
            {
                Console.WriteLine("El resultado de la compuerta logica es: V");
            }

            if (entrada1xor == "V" && entrada2xor == "F" || entrada1xor == "v" && entrada2xor == "f" || entrada1xor == "V" && entrada2xor == "f" || entrada1xor == "v" && entrada2xor == "F")
            {
                Console.WriteLine("El resultado de la compuerta logica es: V");
            }

            if (entrada1xor == "V" && entrada2xor == "V" || entrada1xor == "v" && entrada2xor == "v" || entrada1xor == "V" && entrada2xor == "v" || entrada1xor == "v" && entrada2xor == "V")
            {
                Console.WriteLine("El resultado de la compuerta logica es: F");
            }


            Console.ReadKey();
        }
    }
}
