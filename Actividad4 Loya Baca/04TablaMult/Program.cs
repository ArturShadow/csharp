//Luis Arturo Loya Baca
//TID11D
using System;

namespace _04TablaMult
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla = 0;
            Console.Write("Cual tabla de multilicar desea conocer ");
            tabla = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++){
                Console.WriteLine(tabla + " * " + i + " = " + (tabla*i));
            }

        }
    }
}
