using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Npersonas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxPersonas = 50;
            string[] nombres = new string[MaxPersonas];
            int contador = 0;

            Console.WriteLine("Ingrese un numero máximo de personas: " + MaxPersonas);
            Console.WriteLine("========================================");
            Console.WriteLine("El número máximo establecido es de " + MaxPersonas + " personas, presione una tecla para comenzar a contar...");
            Console.ReadKey();

            Console.Clear(); 

            while (true)
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Agregar una persona.");
                Console.WriteLine("2. Mostrar todas las personas.");
                Console.WriteLine("3. Salir.");
                Console.Write("Ingrese su opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        if (contador < MaxPersonas)
                        {
                            Console.Write("Ingrese el nombre de la persona: ");
                            string nombre = Console.ReadLine();
                            nombres[contador] = nombre;
                            contador++;
                            Console.WriteLine("Persona agregada exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Se ha alcanzado el numero máximo de personas : ");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Personas almacenadas:");
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + nombres[i]);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida (1, 2 o 3).");
                        break;


                }
            }

        }
    }
}
