using System;

namespace Sistema_Servicios_Escolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int op_menu = 0, numAlumno = 0, op_campo, i;
            string res = "si";
            bool flag = true;
            string[] nombre = { "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato" };
            string[] grupo = { "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato" };
            string[] matricula = { "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato", "Sin dato" };
            int[] promedio = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1. Dar de alta alumnos");
                Console.WriteLine("2. Dar de baja alumnos");
                Console.WriteLine("3. Cambiar datos de un alumno");
                Console.WriteLine("4. Mostrar los datos de un alumno");
                Console.WriteLine("5. Mostrar todos la lista de alumnos");
                Console.WriteLine("6. Salir del programa");
                Console.Write("Selecione una opcion --> ");
                op_menu = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op_menu)
                {
                    case 1: //
                        for (i = 0; i < nombre.Length; i++)
                        {
                            Console.WriteLine("Ingrese los datos del alumno #" + (i + 1) + ":");
                            Console.Write("Nombre: ");
                            nombre[i] = Console.ReadLine();
                            Console.Write("Matricula:");
                            matricula[i] = Console.ReadLine();
                            // matricula[i] = mat;
                            Console.Write("Grupo: ");
                            grupo[i] = Console.ReadLine();
                            Console.Write("Promedio: ");
                            promedio[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("De cual alumno quiere borrar los datos? ");
                        numAlumno = int.Parse(Console.ReadLine()) - 1;
                        nombre[numAlumno] = "Sin dato";
                        matricula[numAlumno] = "Sin dato";
                        grupo[numAlumno] = "Sin dato";
                        promedio[numAlumno] = 0;
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("A cuantos alumnos desea hacer cambios? ");
                        numAlumno = int.Parse(Console.ReadLine());
                        for (i = 0; i < numAlumno; i++)
                        {
                            Console.WriteLine("I = " + i);
                            Console.Write("A cual alumno quiere hacer cambios? ");
                            numAlumno = int.Parse(Console.ReadLine()) - 1;
                            Console.Write("A cuantos campos quiere hacer cambios? ");
                            int noCampos = int.Parse(Console.ReadLine());
                            for (int j = 0; j <= noCampos; j++)
                            {
                                Console.WriteLine("J = " + j);
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
                                        Console.Write("Ingrese el nuevo promedio: ");
                                        promedio[numAlumno] = int.Parse(Console.ReadLine());
                                        do
                                        {
                                            Console.Write("Desea guardar el cambio? ");
                                            res = Console.ReadLine().ToLower();
                                            if (res == "s" || res == "si")
                                            {
                                                Console.WriteLine("Se ha guardado los cambios");
                                            }
                                        } while (res == "n" || res == "no");
                                        break;
                                }
                            }
                        }
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("De cual alumno quiere los datos ");
                        numAlumno = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Nombre: " + nombre[numAlumno]);
                        Console.WriteLine("Matricula: " + matricula[numAlumno]);
                        Console.WriteLine("Grupo: " + grupo[numAlumno]);
                        Console.WriteLine("Promedio: " + promedio[numAlumno]);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:

                        int auxPromedio = 0;
                        string auxNombre = "", auxMatricula = "", auxGrupo = "";
                        bool ordenado = false;
                        for (i = 0; i < promedio.Length && ordenado == false; i++)
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
                        for (i = 0; i < nombre.Length; i++)
                        {
                            Console.WriteLine("{0}\t\t{1}\t\t\t{2}\t\t{3}", nombre[i], matricula[i], grupo[i], promedio[i]);

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