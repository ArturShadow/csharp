using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num1;
            // int num2;
            // int num3;
            int mayor;
            int menor;
            int num;
            // int cont;
            int i;

            // num1 = 0;
            // num2 = 0;
            // num3 = 0;
            mayor = 0;
            menor = 0;
            num = 0;
            // cont = 1;

            // Console.WriteLine("Ingresa el primer numero");
            // num1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Ingresa el primer numero");
            // num2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Ingresa el primer numero");
            // num3 = int.Parse(Console.ReadLine());

            // if(num1>num1) {
            //     mayor = num2;
            // }else {
            //     mayor = num2;
            // }
            // if(num3 > mayor) {
            //     mayor = num3;
            // }


            // if((num1 > num2) && (num1 > num3)) {
            //     mayor = num1;
            // } else{
            //     if (num2 > num3) {
            //         mayor = num2;
            //     } else {
            //         mayor = num3;
            //     }
            // }
            // if ((num1 > num2) && (num1 < num3)) {
            //     menor = num1;
            // } else {
            //     if(num2 < num3) {
            //         menor = num2;
            //     } else {
            //         menor = num3;
            //     }
            // }

            // Console.WriteLine("Ingresa un numero");
            // num = int.Parse(Console.ReadLine());

            for (i = 1; i < int.MaxValue; i++) {
                Console.WriteLine("Ingresa otro numero");
                num = int.Parse(Console.ReadLine());
                if(num > 0) {
                    if(i == 1){
                        Console.WriteLine("Entra");
                        mayor = num;
                        menor = num;
                    }
                }
                if(num > 0) {
                    if(num >= mayor){
                        Console.WriteLine("Entra");
                        mayor = num;
                    }
                }
                if(num > 0) {
                    if(num <= menor){
                        Console.WriteLine("Entra");
                        menor = num;
                    } 
                }

                }
                if(num == 0) {
                    i = int.MaxValue;
                }
            
            Console.WriteLine("El numero mayor es " + mayor + " y el numero menor es " + menor);
            


        }
    }
}
