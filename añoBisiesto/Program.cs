using System;

namespace añoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;

            Console.WriteLine("Cual es el año a evalualar");
            year = int.Parse(Console.ReadLine());

            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                Console.WriteLine("El año " + year + " es bisiesto");
            } else {
                Console.WriteLine("El año " + year + " no es bisiesto");
            }
        }
    }
}
