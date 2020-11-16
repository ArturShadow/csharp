using System;

namespace _05Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1, numero = 0;

            Console.Write("Dame un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                fact = fact * i;
            }
            Console.Write("El factorial de " + numero + " es: " + fact);
        }
    }
}
