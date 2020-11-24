using System;

namespace NumerosArabigosARomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int millares = 0, centenas = 0, decenas = 0, unidades = 0, num = 0;
            Console.Write("Ingresa un numero: ");
            do{
                if(num >= 4000)
                {
                    Console.WriteLine("Solo se permiten numeros por debajo de 4000");
                }
                num = int.Parse(Console.ReadLine());
            } while(num >= 4000);

            Console.Write(num + " en numeros romanos es: ");
            

            millares = (num / 1000) % 10;
            centenas = (num / 100) % 10;
            decenas = (num / 10) % 10;
            unidades = (num / 1) % 10;

            Console.WriteLine("Millares: " + millares);
            Console.WriteLine("Millares: " + centenas);
            Console.WriteLine("Millares: " + decenas);
            Console.WriteLine("Millares: " + unidades);
            //Millares
            switch (millares)
            {
                case 1:
                    Console.Write("M");
                    break;

                case 2:
                    Console.Write("MM");
                    break;
                case 3:
                    Console.Write("MMM");
                    break;
            }
            //Centenas
            switch (centenas)
            {
                case 1:
                    Console.Write("C");
                    break;
                case 2:
                    Console.Write("CC");
                    break;
                case 3:
                    Console.Write("CCC");
                    break;
                case 4:
                    Console.Write("CD");
                    break;
                case 5:
                    Console.Write("D");
                    break;
                case 6:
                    Console.Write("DC");
                    break;
                case 7:
                    Console.Write("DCC");
                    break;
                case 8:
                    Console.Write("DCCC");
                    break;
                case 9:
                    Console.Write("CM");
                    break;
            }
            //Decenas
            switch (decenas)
            {
                case 1:
                    Console.Write("X");
                    break;
                case 2:
                    Console.Write("XX");
                    break;
                case 3:
                    Console.Write("XXX");
                    break;
                case 4:
                    Console.Write("LX");
                    break;
                case 5:
                    Console.Write("L");
                    break;
                case 6:
                    Console.Write("LX");
                    break;
                case 7:
                    Console.Write("LXX");
                    break;
                case 8:
                    Console.Write("LXXX");
                    break;
                case 9:
                    Console.Write("XC");
                    break;
            }
            //unidades
            switch (unidades)
            {
                case 1:
                    Console.Write("I");
                    break;
                case 2:
                    Console.Write("II");
                    break;
                case 3:
                    Console.Write("III");
                    break;
                case 4:
                    Console.Write("IV");
                    break;
                case 5:
                    Console.Write("V");
                    break;
                case 6:
                    Console.Write("VI");
                    break;
                case 7:
                    Console.Write("VII");
                    break;
                case 8:
                    Console.Write("VIII");
                    break;
                case 9:
                    Console.Write("IX");
                    break;
            }
        }
    }
}
