using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // int puntos1;
            // int puntos2;
            // int puntos3;
            int mayor;
            int menor;
            int puntos;
            // int cont;
            int i;

            // puntos1 = 0;
            // puntos2 = 0;
            // puntos3 = 0;
            mayor = 0;
            menor = 0;
            puntos = 0;
            // cont = 1;

            // Console.WriteLine("Ingresa el primer puntosero");
            // puntos1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Ingresa el primer puntosero");
            // puntos2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Ingresa el primer puntosero");
            // puntos3 = int.Parse(Console.ReadLine());

            // if(puntos1>puntos1) {
            //     mayor = puntos2;
            // }else {
            //     mayor = puntos2;
            // }
            // if(puntos3 > mayor) {
            //     mayor = puntos3;
            // }


            // if((puntos1 > puntos2) && (puntos1 > puntos3)) {
            //     mayor = puntos1;
            // } else{
            //     if (puntos2 > puntos3) {
            //         mayor = puntos2;
            //     } else {
            //         mayor = puntos3;
            //     }
            // }
            // if ((puntos1 > puntos2) && (puntos1 < puntos3)) {
            //     menor = puntos1;
            // } else {
            //     if(puntos2 < puntos3) {
            //         menor = puntos2;
            //     } else {
            //         menor = puntos3;
            //     }
            // }

            // Console.WriteLine("Ingresa un puntosero");
            // puntos = int.Parse(Console.ReadLine());

            for (i = 1; i < int.MaxValue; i++) {
                Console.WriteLine("Ingresa otro puntosero");
                puntos = int.Parse(Console.ReadLine());
                if(puntos > 0) {
                    if(i == 1){
                        //Console.WriteLine("Entra");
                        mayor = puntos;
                        menor = puntos;
                    }
                }
                if(puntos > 0) {
                    if(puntos >= mayor){
                        //Console.WriteLine("Entra");
                        mayor = puntos;
                    }
                }
                if(puntos > 0) {
                    if(puntos <= menor){
                        //Console.WriteLine("Entra");
                        menor = puntos;
                    } 
                }

                }
                if(puntos == 0) {
                    i = int.MaxValue;
                }
            
            Console.WriteLine("El puntosero mayor es " + mayor + " y el puntosero menor es " + menor);
            


        }
    }
}
