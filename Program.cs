using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Persona> personas = new List<Persona>();

        while (true)
        {
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Crear Estudiante");
            Console.WriteLine("2. Crear Personal");
            Console.WriteLine("3. Mostrar Personas");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre: ");
                    string nombreE = Console.ReadLine();

                    Console.Write("Dirección: ");
                    string direccionE = Console.ReadLine();

                    Console.Write("Carrera: ");
                    string carrera = Console.ReadLine();

                    Console.Write("Año: ");
                    int año = int.Parse(Console.ReadLine());

                    Estudiante estudiante = new Estudiante(nombreE, direccionE, carrera, año);
                    personas.Add(estudiante);
                    Console.WriteLine("Estudiante creado con éxito.");
                    Console.WriteLine("==========================================");
                    break;

                case 2:
                    Console.Write("Nombre: ");
                    string nombreP = Console.ReadLine();

                    Console.Write("Dirección: ");
                    string direccionP = Console.ReadLine();

                    Console.Write("Universidad: ");
                    string universidad = Console.ReadLine();

                    Console.Write("Salario: ");
                    double salario = double.Parse(Console.ReadLine());

                    Personal personal = new Personal(nombreP, direccionP, universidad, salario);
                    personas.Add(personal);
                    Console.WriteLine("Personal creado con éxito.");
                    Console.WriteLine("==========================================");
                    break;

                case 3:
                    foreach (var persona in personas)
                    {
                        Console.WriteLine(persona.ToString()); 
                        Console.WriteLine("--------------------------");
                    }
                    break;

                case 4:
                    Console.WriteLine("Gracias por usar el programa. !Hastas luego¡");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    Console.WriteLine("==========================================");
                    break;
            }
        }
    }
}

