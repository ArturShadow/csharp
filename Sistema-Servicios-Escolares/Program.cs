/*
Luis Arturo Loya Baca
TID11D
*/
using System;
namespace Sistema_Servicios_Escolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int op_menu = 0, numAlumno = 0, op_campo, i;
            string mat = "";
            bool flag = true;
            string[] nombre = new string[5];
            string[] grupo = new string[5];
            string[] matricula = new string[5];
            int[] promedio = new int[5];
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1. Dar de alta alumno");
                Console.WriteLine("2. Dar de baja alumno");
                Console.WriteLine("3. Cambiar datos de un alumno");
                Console.WriteLine("4. Mostrar los datos de un alumno");
                Console.WriteLine("5. Mostrar la lista de alumnos");
                Console.WriteLine("6. Salir del programa");
                Console.Write("Selecione una opcion --> ");
                op_menu = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op_menu)
                {
                    case 1: //Opcion para guardar los datos en los areglos
                        int prom = 0, numAlumnos = 0;
                        for (i = 0; i < nombre.Length; i++)
                        {
                            Console.WriteLine("Ingrese los datos del alumno #" + (i + 1) + ":");
                            Console.Write("Nombre: ");
                            nombre[i] = Console.ReadLine();
                            do
                            {
                                Console.Write("Matricula: ");
                                mat = Console.ReadLine();
                                if (mat.Length == 10) //Verificar si la matricula tiene 10 digitos
                                {
                                    matricula[i] = mat;
                                }
                                else
                                {
                                    Console.WriteLine("La matricula debe de tener 10 digitos, intente de nuevo");
                                }
                            } while (mat.Length != 10); //Si la matrucla tiene mas de 10 o menos se va a volver a preguntar

                            Console.Write("Grupo: ");
                            grupo[i] = Console.ReadLine();
                            do
                            {
                                Console.Write("Promedio: ");
                                prom = int.Parse(Console.ReadLine());
                                if (prom >= 7 || prom <= 10) //Verificsr si el promedio esta entre 7 y 10
                                {
                                    promedio[i] = prom;
                                }
                                else
                                {
                                    Console.WriteLine("El promedio debe ser entre 7 y 10, intente de nuevo");
                                }
                            } while (prom < 7 || prom > 10); // Se va a volver a preguntar si el promedio no esta detro del rango establecido
                        }
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2: //Borrar los datos de un alumno
                        string res = "no";
                        do
                        {
                            Console.Write("De cual alumno quiere borrar los datos? ");
                            numAlumno = int.Parse(Console.ReadLine()) - 1;
                            nombre[numAlumno] = "";//Borrar la informacion del alumno del espacio
                            matricula[numAlumno] = "";
                            grupo[numAlumno] = "";
                            promedio[numAlumno] = 0;
                            Console.WriteLine("Se han borrado los datos");

                            Console.WriteLine("Quiere borar los datos de otro alumno? ");
                            res = Console.ReadLine().ToLower();
                        } while (res == "s" || res == "si");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        int noCampos = 0;
                        do
                        {
                            Console.Write("A cuantos alumnos desea hacer cambios? "); //Permitir hacer cambios a varios alumnos
                            numAlumnos = int.Parse(Console.ReadLine());
                            if (numAlumnos > nombre.Length)
                            {
                                Console.WriteLine("No hay informacion");
                            }
                        } while (numAlumnos > nombre.Length); //Se repite mientras que el numero de alumnos sea a mayor a los guardados
                        for (i = 0; i <= numAlumno; i++)
                        {
                            do
                            {
                                Console.Write("A cual alumno quiere hacer cambios? ");
                                numAlumno = int.Parse(Console.ReadLine()) - 1;
                                if (numAlumno > nombre.Length)
                                {
                                    Console.WriteLine("No hay informacion");
                                }
                            } while (numAlumno >= nombre.Length);
                            do
                            {
                                Console.Write("A cuantos campos quiere hacer cambios? ");
                                noCampos = int.Parse(Console.ReadLine());
                                if (noCampos > 3)
                                {
                                    Console.WriteLine("Solo se puede hacer cambios a 3 capos: nombre, grupo y promedio");
                                }
                            } while (noCampos > 3); //Se repite mientras que el numero de campos ingresados sea mayor a 3
                            for (int j = 0; j <= noCampos - 1; j++) //Permitir hacer cambios a varios campos
                            {
                                Console.WriteLine("A que campo quiere hacer cambios?");
                                Console.WriteLine("1. Nombre");
                                Console.WriteLine("2. Grupo");
                                Console.WriteLine("3. Promedio");
                                do
                                {
                                    Console.Write("Ingrese la opcion --> ");
                                    op_campo = int.Parse(Console.ReadLine());
                                    if (op_campo > 3)
                                    {
                                        Console.WriteLine("No hay un campo de informacion modificable con esa opcion");
                                    }
                                } while (op_campo > 3);
                                switch (op_campo)
                                {
                                    case 1:
                                        Console.Write("Ingrese el nuevo nombre: ");
                                        nombre[numAlumno] = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.Write("Ingresa el nuevo grupo: ");
                                        grupo[numAlumno] = Console.ReadLine();
                                        break;
                                    case 3:
                                        do
                                        {
                                            Console.Write("Ingrese el nuevo promedio: ");
                                            prom = int.Parse(Console.ReadLine());
                                            if (prom < 7 || prom > 10) //Verificar si el promedio
                                            {
                                                Console.WriteLine("El promedio debe ser entre 7 y 10, intente de nuevo");
                                            }
                                            else
                                            {
                                                promedio[numAlumno] = prom;
                                            }
                                        } while (prom < 7 || prom > 10);
                                        break;
                                }
                            }
                        }
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4: //Mostrar la informacion de un solo alumno
                        do
                        {
                            do
                            {
                                Console.Write("De cual alumno quire los datos? ");
                                numAlumno = int.Parse(Console.ReadLine());
                                if (numAlumno > nombre.Length)
                                {
                                    Console.WriteLine("No hay informacion");
                                }
                                else
                                {
                                    numAlumno = numAlumno - 1;
                                }
                            } while (numAlumno >= nombre.Length);
                            Console.WriteLine("Nombre: " + nombre[numAlumno]);
                            Console.WriteLine("Matricula: " + matricula[numAlumno]);
                            Console.WriteLine("Grupo: " + grupo[numAlumno]);
                            Console.WriteLine("Promedio: " + promedio[numAlumno]);
                            Console.WriteLine("Quiere los datos de otro alumno? ");
                            res = Console.ReadLine().ToLower();
                            if (res == "s" || res == "si")
                            {
                                Console.Clear();
                            }
                        } while (res == "s" || res == "si");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5: //Mostrar la informacion de todos los alumnos

                        int auxPromedio = 0;
                        string auxNombre = "", auxMatricula = "", auxGrupo = "";
                        bool ordenado = false;
                        for (i = 0; i < promedio.Length && ordenado == false; i++) //Ordenar la informacion por promedios
                        {
                            ordenado = true;
                            for (int j = 0; j < promedio.Length - 1; j++)
                            {
                                if (promedio[j] < promedio[j + 1])
                                {
                                    ordenado = false;

                                    auxNombre = nombre[j];
                                    nombre[j] = nombre[j + 1];
                                    nombre[j + 1] = auxNombre;

                                    auxMatricula = matricula[j];
                                    matricula[j] = matricula[j + 1];
                                    matricula[j + 1] = auxMatricula;

                                    auxGrupo = grupo[j];
                                    grupo[j] = grupo[j + 1];
                                    grupo[j + 1] = auxGrupo;

                                    auxPromedio = promedio[j];
                                    promedio[j] = promedio[j + 1];
                                    promedio[j + 1] = auxPromedio;
                                }
                            }
                        }
                        Console.WriteLine("Nombre\t\t\tMatricula\t\t\tGrupo\t\t\tPromedio");
                        for (i = 0; i < nombre.Length; i++) //Mostrar la informacion
                        {
                            Console.WriteLine("{0}\t\t{1}\t\t\t{2}\t\t\t{3}", nombre[i], matricula[i], grupo[i], promedio[i]);
                            /*Nota: La informacion se mueve segun el tamaño del nombre, no supe como hacer para que estuvieran a la misma distancia*/

                        }
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Ha salido del programa");
                        flag = false;
                        break;
                }
            } while (flag == true);
        }
    }
}