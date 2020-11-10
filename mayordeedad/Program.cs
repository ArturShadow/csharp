using System;

namespace mayordeedad
{
    class Program
    {
        static void Main(string[] args)
        {
        String nombre;
        int edad;
            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("Cual es tu edad?");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18) {
                System.Console.WriteLine(nombre + " eres mayor de edad");
            } else {
                System.Console.WriteLine(nombre + " no eres mayor de edad");
            }
        }
    }
}
