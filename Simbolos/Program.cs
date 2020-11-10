using System;

namespace Simbolos
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double res;

            num1 = 0;
            num2 = 0;
            res = 0;


            Console.WriteLine("Hello World!");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello World!");
            num2 = int.Parse(Console.ReadLine());

            res = Math.Pow(num1, num2);

            Console.WriteLine(res);
        }
    }
}
