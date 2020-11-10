using System;

namespace Mayoria_de_edad
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

            Console.WriteLine(edad);
            if (edad >= 18) {
                System.Console.WriteLine(nombre + "eres mayor de edad");
            }
        }
    }
}
