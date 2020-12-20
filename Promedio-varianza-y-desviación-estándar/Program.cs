//Luis Arturo Loya Baca
//TID11D

using System;

namespace Promedio_varianza_y_desviación_estándar
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0, num = 0, acum = 0, i;
            double promedio = 0, desviacion = 0, varianza = 0, aux = 0, aux2 = 0, aux3 = 0, power = 2;

            //Se pregunta cuantos numeros se van a introducir para rever espacio pqr un arereglo
            Console.Write("Cuantos numeros se van a capturar? ");
            cantidad = int.Parse(Console.ReadLine());
            double[] numeros = new double[cantidad];

            for (i = 0; i < cantidad; i++) //Calcular la suma de todos los numeros y guadarlos despues en un arreglo
            {
                Console.Write("Cual es el numero #" + (i + 1) + ": ");
                num = int.Parse(Console.ReadLine());
                acum = acum + num;
                numeros[i] = num;
            }
            promedio = (double)acum / cantidad; //Calcula el promedio
            for (i = 0; i < cantidad; i++) //Calcula la suma y la diferencia entre 
            {
                aux = numeros[i]; // Saca un numero y encuentra la diferencia
                aux2 = (aux - promedio);
                aux3 = aux3 + (Math.Pow(aux2, power)); //Calcula la suma de las potencias de todos los numeros
            }
            desviacion = Math.Sqrt( aux3 / (cantidad - 1)); //calcula la raiz de la suma, y lo divide
            varianza = Math.Pow(desviacion, power); //Eleva la desviacio para obtener la varianza
            Console.Write("Los numeros ingresados son: ");//Mostrar los resultadoas
            for (i = 0; i < cantidad; i++)
            {
                Console.Write(numeros[i]);
                if (i == cantidad - 1)
                {
                    Console.Write(".\n");
                }
                else
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Desviacion estandar: " + desviacion);
            Console.WriteLine("Varianza: " + varianza);


        }
    }
}
