using System;

namespace _02CentroVerific
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntos = 0, acum = 0, mayor = 0, menor = 0, promedio = 0, i;
            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingresa puntos contaminantes del auto #" + i);
                puntos = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    //Console.WriteLine("Entra");
                    mayor = puntos;
                    menor = puntos;
                }
                if (puntos >= mayor)
                {
                    //Console.WriteLine("Entra");
                    mayor = puntos;
                }

                if (puntos <= menor)
                {
                    //Console.WriteLine("Entra");
                    menor = puntos;
                }

                acum = acum + puntos;
            }
            promedio = acum / i;
            Console.WriteLine("mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("promedio: " + promedio);


        }
    }
}

