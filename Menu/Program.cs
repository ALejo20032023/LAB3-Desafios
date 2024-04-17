using System;
using System.Collections.Generic;

class Program
{
    static List<string> listaTareas = new List<string>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            MostrarMenu();
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarTareas();
                    break;
                case "2":
                    AgregarTarea();
                    break;
                case "3":
                    EliminarTarea();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n----- MENÚ -----");
        Console.WriteLine("1. Mostrar Tareas");
        Console.WriteLine("2. Agregar Tarea");
        Console.WriteLine("3. Eliminar Tarea");
        Console.WriteLine("4. Salir");
    }

    static void MostrarTareas()
    {
        if (listaTareas.Count == 0)
        {
            Console.WriteLine("No hay tareas por realizar.");
        }
        else
        {
            Console.WriteLine("\n----- LISTA DE TAREAS -----");
            for (int i = 0; i < listaTareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaTareas[i]}");
            }
        }
    }

    static void AgregarTarea()
    {
        Console.Write("Ingrese la nueva tarea: ");
        string nuevaTarea = Console.ReadLine();
        listaTareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada con éxito.");
    }

    static void EliminarTarea()
    {
        if (listaTareas.Count == 0)
        {
            Console.WriteLine("No hay tareas por eliminar.");
        }
        else
        {
            Console.Write("Ingrese el número de la tarea que desea eliminar: ");
            int indice;
            if (int.TryParse(Console.ReadLine(), out indice))
            {
                if (indice > 0 && indice <= listaTareas.Count)
                {
                    listaTareas.RemoveAt(indice - 1);
                    Console.WriteLine("Tarea eliminada con éxito.");
                }
                else
                {
                    Console.WriteLine("Número de tarea no válido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor ingrese un número válido.");
            }
        }
    }
}
