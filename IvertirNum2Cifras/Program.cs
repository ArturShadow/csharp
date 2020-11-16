using System;

namespace Ivertirpuntos2Cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntos, dec, uni, cen, aux;
            Console.WriteLine("Ingresa un puntosero de 2 cifras");
            puntos = int.Parse(Console.ReadLine());
            uni = puntos % 10;
            aux = puntos / 10;
            dec = aux % 10;
            aux = aux / 10;
            cen = aux % 10;


            // Console.WriteLine(cen + "" + dec + "" + uni);
            Console.WriteLine(cen);
            Console.WriteLine(dec);
            Console.WriteLine(uni);
            // Console.WriteLine(aux);
            // Console.WriteLine(aux);

        }
    }
}
