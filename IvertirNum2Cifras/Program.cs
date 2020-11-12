using System;

namespace IvertirNum2Cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dec, uni, cen, aux;
            Console.WriteLine("Ingresa un numero de 2 cifras");
            num = int.Parse(Console.ReadLine());
            uni = num % 10;
            aux = num / 10;
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
