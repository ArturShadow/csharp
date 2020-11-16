using System;

namespace Test
{
   class Program
    {
        static void Main(string[] args)
        {
            int num = 0, acum = 0, mayor = 0, menor = 0, promedio = 0, i;
            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingresa num contaminantes del auto #" + i);
                num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    //Console.WriteLine("Entra");
                    mayor = num;
                    menor = num;
                }
                if (num >= mayor)
                {
                    //Console.WriteLine("Entra");
                    mayor = num;
                }

                if (num <= menor)
                {
                    //Console.WriteLine("Entra");
                    menor = num;
                }

                acum = acum + num;
            }
            promedio = acum / i;
            Console.WriteLine("mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("promedio: " + promedio);


        }
    }
}
