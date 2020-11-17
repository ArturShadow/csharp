//Luis Arturo Loya Baca
//TID11D
using System;

namespace _02CentroVerific
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntos = 0, acum = 0, mayor = 0, menor = 0, promedio = 0, i, noMenosContaminador = 0, noMasContaminador = 0;
            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingresa puntos contaminantes del auto #" + i);
                puntos = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    
                    mayor = puntos;
                    menor = puntos;
                }
                if (puntos >= mayor)
                {
                    noMasContaminador = i;
                    mayor = puntos;
                }

                if (puntos <= menor)
                {
                    noMenosContaminador = i;
                    menor = puntos;

                }

                acum = acum + puntos;
            }
            promedio = acum / i;
            Console.WriteLine("El auto #" + noMasContaminador + " es el mayor con " + mayor + " puntos de contaminacion");
            Console.WriteLine("El auto #" + noMenosContaminador + " es el menor con " + menor + " puntos de contaminacion");
            Console.WriteLine("Y el promedio es de: " + promedio);


        }
    }
}

