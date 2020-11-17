//Luis Arturo Loya Baca
//TID11D
using System;

namespace _03NumMenMay
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, mayor = 0, menor = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingresa un numero");
                num = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    mayor = num;
                    menor = num;
                }
                if (num >= mayor)
                {

                    mayor = num;
                }

                if (num <= menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
        }
    }
}
