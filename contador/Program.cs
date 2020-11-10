using System;

namespace contador
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write(j);
                    if(j == 5)
                    {
                        Console.Write(".");
                    } else{
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
