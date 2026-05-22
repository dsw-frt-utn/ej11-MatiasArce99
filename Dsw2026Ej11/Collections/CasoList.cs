namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Collections.Generic;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumno = new List<Alumno>();
    
    public void AgregarAlumno(Alumno a)
    {
        alumno.Add(a);
    }

    public string ListarAlumnos()
    {
        string resultado = "";
        foreach (Alumno a in alumno)
        {
            resultado += a.ToString() + "\n";
        }
        return resultado;
    }

    public Alumno? BuscarAlumnoPorNombre(string nombre)
    {
        foreach (Alumno a in alumno)
        {
            if (a.Nombre == nombre)
            {
                Console.WriteLine($"Existe: {a}");
                return a;
            } else
            {
                Console.WriteLine("No existe");
            }
        }
        return null;
    }

    public void EliminarAlumno(Alumno a)
    {
        alumno.Remove(a);
    }

    public void EliminarAlumnoPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumno.Count)
        {
            alumno.RemoveAt(posicion);
        }
    }
}
