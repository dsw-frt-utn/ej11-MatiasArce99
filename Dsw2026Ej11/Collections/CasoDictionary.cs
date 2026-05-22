namespace Dsw2026Ej11.Collections;
using System.Collections.Generic;
using Dsw2026Ej11.Domain;
//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumno = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno a)
    {
        alumno.Add(a.Id, a);
    }

    public string ListarAlumnos()
    {
        string resultado = "";
        foreach (var a in alumno.Values)
        {
            resultado += a.ToString() + "\n";
        }
        return resultado;
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        if (alumno.TryGetValue(legajo, out Alumno? a))
        {
            return a;
        }
        else
        {
            Console.WriteLine("No existe");
            return null;
        }
    }

    public Dictionary<int, Alumno> ObtenerAlumnos()
    {
        return alumno;
    }

    public void EliminarAlumno(int legajo)
    {
        alumno.Remove(legajo);
    }
}
