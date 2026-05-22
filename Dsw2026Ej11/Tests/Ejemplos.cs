namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Collections.Generic;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
        casoList.AgregarAlumno(new Alumno(1111, "Juan", 8.5));
        casoList.AgregarAlumno(new Alumno(2222, "Maria", 9.0));
        casoList.AgregarAlumno(new Alumno(3333, "Pedro", 7.5));

        Console.WriteLine(casoList.ListarAlumnos());

        casoList.BuscarAlumnoPorNombre("Maria");
        casoList.BuscarAlumnoPorNombre("Daniel");

        casoList.EliminarAlumno(new Alumno(2222, "Maria", 9.0));
        Console.WriteLine(casoList.ListarAlumnos());

        casoList.EliminarAlumnoPorPosicion(0);
        Console.WriteLine(casoList.ListarAlumnos());
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();
        casoDictionary.AgregarAlumno(new Alumno(4444, "Esteban", 8.5));
        casoDictionary.AgregarAlumno(new Alumno(5555, "Erika", 9.0));
        casoDictionary.AgregarAlumno(new Alumno(6666, "Guillermina", 7.5));        
        Console.WriteLine(casoDictionary.ListarAlumnos());

        Console.WriteLine(casoDictionary.BuscarAlumno(5555));
        Console.WriteLine(casoDictionary.BuscarAlumno(7777));

        casoDictionary.EliminarAlumno(5555);
        Console.WriteLine(casoDictionary.ListarAlumnos());
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        List<Libro> libros = Libro.CrearLista();
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine($"{casoLinq.GetPrimero()?.Titulo}");
        Console.WriteLine($"{casoLinq.GetUltimo()?.Titulo}");
        Console.WriteLine($"{casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"{casoLinq.GetPromedioPrecios():C}");
        Console.WriteLine("\nLibros con Id mayor a 15:");
        foreach (var libro in casoLinq.GetListById())
            Console.WriteLine($"- {libro.Titulo} (ID: {libro.Id})");

        Console.WriteLine("\nLista de títulos y precios:");
        foreach (var libroFormateado in casoLinq.GetLibros())
            Console.WriteLine($"{libroFormateado}");

        var mayor = casoLinq.GetMayorPrecio();
        Console.WriteLine($"\n{mayor?.Titulo} ({mayor?.Precio:C})");

        var menor = casoLinq.GetMenorPrecio();
        Console.WriteLine($"{menor?.Titulo} ({menor?.Precio:C})");

        Console.WriteLine("\n");
        foreach (var libro in casoLinq.GetMayorPromedio())
            Console.WriteLine($"{libro.Titulo} ({libro.Precio:C})");

        Console.WriteLine("\n");
        foreach (var libro in casoLinq.GetLibrosOrdenadosDescendente())
            Console.WriteLine($"{libro.Titulo}");
    }
}
