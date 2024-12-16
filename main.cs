using System;
using System.Collections.Generic;

class Program
{
    static List<string> usuarios = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Sistema de Gestión de Usuarios");
            Console.WriteLine("1. Agregar Usuario");
            Console.WriteLine("2. Listar Usuarios");
            Console.WriteLine("3. Eliminar Usuario");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarUsuario();
                    break;
                case "2":
                    ListarUsuarios();
                    break;
                case "3":
                    EliminarUsuario();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarUsuario()
    {
        Console.Write("Ingrese el nombre del usuario: ");
        string nombre = Console.ReadLine();
        usuarios.Add(nombre);
        Console.WriteLine("Usuario agregado exitosamente.");
    }

    static void ListarUsuarios()
    {
        Console.WriteLine("Lista de Usuarios:");
        foreach (var usuario in usuarios)
        {
            Console.WriteLine(usuario);
        }
    }

    static void EliminarUsuario()
    {
        Console.Write("Ingrese el nombre del usuario a eliminar: ");
        string nombre = Console.ReadLine();
        if (usuarios.Remove(nombre))
        {
            Console.WriteLine("Usuario eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
    }
}
