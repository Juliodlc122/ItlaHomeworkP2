using ComunidadEducativa.Models;
using ComunidadEducativa.Services;
using System;

class Program
{
    static void Main(string[] args)
    {
        ComunidadService servicio = new ComunidadService();

        var estudiante = new Estudiante
        {
            Nombre = "Carlos Pérez",
            Edad = 20,
            Identificacion = "E-001",
            Carrera = "Ingeniería",
            Semestre = 3
        };

        var maestro = new Maestro
        {
            Nombre = "Juan Rodríguez",
            Edad = 35,
            Identificacion = "M-001",
            Puesto = "Profesor de Matemáticas",
            Salario = 25000,
            Materia = "Matemáticas",
            AñosExperiencia = 10
        };


        servicio.AgregarMiembro(estudiante);
        servicio.AgregarMiembro(maestro);

    
        Console.WriteLine("Listado de miembros:");
        foreach (var m in servicio.ObtenerMiembros())
        {
            Console.WriteLine($"{m.Nombre} ({m.GetType().Name})");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
