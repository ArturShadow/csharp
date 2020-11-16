using System;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int op_mes = 0;
            int op_dia = 0;
            Console.WriteLine("Dame el puntosero dia de la semana");
            op_mes = int.Parse(Console.ReadLine());

            switch (op_dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Martes");
                    break;
            
                case 3: 
                    Console.WriteLine("Miercoles");
                    break;
                    
                case 4: 
                    Console.WriteLine("Jueves");
                    break;
                case 5: 
                    Console.WriteLine("Viernes");
                    break;
                case 6: 
                    Console.WriteLine("Sabado");
                    break;
                case 7: 
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("Error, No existe ese dia");
                    break;
        }
    }
}
}
