using System;

namespace Simbolos
{
    class Program
    {
        static void Main(string[] args)
        {
            double puntos1;
            double puntos2;
            double res;

            puntos1 = 0;
            puntos2 = 0;
            res = 0;


            Console.WriteLine("Hello World!");
            puntos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello World!");
            puntos2 = int.Parse(Console.ReadLine());

            res = Math.Pow(puntos1, puntos2);

            Console.WriteLine(res);
        }
    }
}
