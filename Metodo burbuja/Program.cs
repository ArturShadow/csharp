    using System;

namespace Metodo_burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] burbuja = { 100, 50, 80, 60, 90, 10 };
            int aux = 0, i;
            // for (i = 0; i < burbuja.Length; i++)
            // {
            //     for (int j = 0; j < burbuja.Length - 1; j++)
            //     {
            //         if (burbuja[j] < burbuja[j + 1])
            //         {
            //             aux = burbuja[j];
            //             burbuja[j] = burbuja[j + 1];
            //             burbuja[j + 1] = aux;
            //         }
            //     }
            // }
            // for (i = 0; i < burbuja.Length; i++)
            // {
            //     Console.WriteLine(burbuja[i]);
            // }
            for (i = 1; i < burbuja.Length; i++)
            {
                for (int j = 0; j < burbuja.Length - 1; j++)
                {
                    if (burbuja[j] < burbuja[j + 1])
                    {
                        aux = burbuja[j];
                        burbuja[j] = burbuja[j + 1];
                        burbuja[j + 1] = aux;
                    }
                }
            }
            for (i = 0; i < burbuja.Length; i++)
            {
                Console.WriteLine(burbuja[i]);
            }
        }
    }
}