using Mapa_De_Clases.Models;
using System;
using System.Collections.Generic;

namespace MAPA_DE_CLASES
{
    internal class Program
    {
        static List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>();

        static void Main(string[] args)
        {
            // Estos son datos de ejmplo
            miembros.Add(new Empleado(1, "Erika", "Buenfil", DateTime.Now.AddYears(-1), 1250.50m));
            miembros.Add(new Estudiante(2, "Jennifer", "Ingeniería", 2023));
            miembros.Add(new ExAlumno(3, "Marcos", "Redes", DateTime.Now.AddYears(-5)));
            miembros.Add(new Docente(4, "Samuel", "López", DateTime.Now.AddYears(-3), 2000m, "Programación", DateTime.Now.AddYears(-2)));
            miembros.Add(new Administrativo(5, "Carlos", "Santos", DateTime.Now.AddYears(-4), 1500m, "RR.HH.", "Coordinador"));
            miembros.Add(new Administrador(6, "Romina", "López", DateTime.Now.AddYears(-6), 2500m, "TI", DateTime.Now.AddYears(-5), "Gestión", "TI"));
            miembros.Add(new Maestro(7, "Idina", "Menzel", DateTime.Now.AddYears(-7), 1800m, "TI", DateTime.Now.AddYears(-6), "Bases de datos", "TI"));

            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==== Miembros de la Comunidad ====");
                Console.WriteLine("1. Mostrar todos");
                Console.WriteLine("2. Buscar por ID");
                Console.WriteLine("3. Agregar nuevo");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        MostrarTodos();
                        break;
                    case "2":
                        BuscarPorId();
                        break;
                    case "3":
                        AgregarNuevo();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MostrarTodos()
        {
            Console.Clear();
            foreach (var m in miembros)
            {
                string info = "";
                if (m is Empleado e)
                {
                    info = $"Empleado: ID {e.Id}, {e.Nombre} {e.Apellido}, Ingreso: {e.FechaIngreso.ToShortDateString()}, Salario: {e.Salario:C}";
                }
                else if (m is Estudiante es)
                {
                    info = $"Estudiante: ID {es.Id}, {es.Nombre}, Carrera: {es.Carrera}, Año ingreso: {es.AñoIngreso}";
                }
                else if (m is ExAlumno ex)
                {
                    info = $"Ex Alumno: ID {ex.Id}, {ex.Nombre}, Carrera: {ex.Carrera}, Egreso: {ex.FechaEgreso.ToShortDateString()}";
                }
                else if (m is Docente d)
                {
                    info = $"Docente: ID {d.Id}, {d.Nombre} {d.Apellido}, Dept: {d.Departamento}, Ingreso: {d.FechaIngreso.ToShortDateString()}, Salario: {d.Salario:C}";
                }
                else if (m is Administrativo a)
                {
                    info = $"Administrativo: ID {a.Id}, {a.Nombre} {a.Apellido}, Puesto: {a.Puesto}, Dept: {a.Departamento}";
                }
                else if (m is Administrador ad)
                {
                    info = $"Administrador: ID {ad.Id}, {ad.Nombre} {ad.Apellido}, Área: {ad.AreaResponsabilidad}, Cargo: {ad.Cargo}";
                }
                else if (m is Maestro ma)
                {
                    info = $"Maestro: ID {ma.Id}, {ma.Nombre} {ma.Apellido}, Especialidad: {ma.Especialidad}, Curso: {ma.Curso}";
                }
                else
                {
                    info = $"Miembro de la comunidad: ID {m.Id}, {m.Nombre}";
                }
                Console.WriteLine(info);
            }
            Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        static void BuscarPorId()
        {
            Console.Clear();
            Console.Write("Ingrese ID a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var miembro = miembros.Find(m => m.Id == id);
                if (miembro != null)
                {
                    Console.WriteLine("Información encontrada:");
                    MostrarDetalle(miembro);
                }
                else
                {
                    Console.WriteLine("No se encontró miembro con ese ID.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
            Console.WriteLine("Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        static void MostrarDetalle(MiembroDeLaComunidad m)
        {
            if (m is Empleado e)
            {
                Console.WriteLine($"Empleado: {e.Nombre} {e.Apellido}, Ingreso: {e.FechaIngreso.ToShortDateString()}, Salario: {e.Salario:C}");
            }
            else if (m is Estudiante es)
            {
                Console.WriteLine($"Estudiante: {es.Nombre}, Carrera: {es.Carrera}, Año ingreso: {es.AñoIngreso}");
            }
            else if (m is ExAlumno ex)
            {
                Console.WriteLine($"Ex Alumno: {ex.Nombre}, Carrera: {ex.Carrera}, Egreso: {ex.FechaEgreso.ToShortDateString()}");
            }
            else if (m is Docente d)
            {
                Console.WriteLine($"Docente: {d.Nombre} {d.Apellido}, Departamento: {d.Departamento}, Ingreso: {d.FechaIngreso.ToShortDateString()}, Salario: {d.Salario:C}");
            }
            else if (m is Administrativo a)
            {
                Console.WriteLine($"Administrativo: {a.Nombre} {a.Apellido}, Puesto: {a.Puesto}, Departamento: {a.Departamento}");
            }
            else if (m is Administrador ad)
            {
                Console.WriteLine($"Administrador: {ad.Nombre} {ad.Apellido}, Área: {ad.AreaResponsabilidad}, Cargo: {ad.Cargo}");
            }
            else if (m is Maestro ma)
            {
                Console.WriteLine($"Maestro: {ma.Nombre} {ma.Apellido}, Especialidad: {ma.Especialidad}, Curso: {ma.Curso}");
            }
            else
            {
                Console.WriteLine($"Miembro: {m.Nombre}");
            }
        }

        static void AgregarNuevo()
        {
            Console.Clear();
            Console.WriteLine("Agregar nuevo miembro");
            Console.Write("ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID inválido.");
                Console.ReadKey();
                return;
            }
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Seleccione Tipo:");
            Console.WriteLine("1. Empleado");
            Console.WriteLine("2. Estudiante");
            Console.WriteLine("3. ExAlumno");
            Console.WriteLine("4. Docente");
            Console.WriteLine("5. Administrativo");
            Console.WriteLine("6. Administrador");
            Console.WriteLine("7. Maestro");
            Console.Write("Opción: ");
            string tipo = Console.ReadLine();
            MiembroDeLaComunidad nuevo = null;
            if (tipo == "1") nuevo = CrearEmpleado(id, nombre);
            else if (tipo == "2") nuevo = CrearEstudiante(id, nombre);
            else if (tipo == "3") nuevo = CrearExAlumno(id, nombre);
            else if (tipo == "4") nuevo = CrearDocente(id, nombre);
            else if (tipo == "5") nuevo = CrearAdministrativo(id, nombre);
            else if (tipo == "6") nuevo = CrearAdministrador(id, nombre);
            else if (tipo == "7") nuevo = CrearMaestro(id, nombre);
            else
            {
                Console.WriteLine("Tipo inválido.");
                Console.ReadKey();
                return;
            }
            miembros.Add(nuevo);
            Console.WriteLine("Miembro agregado con éxito.");
            Console.ReadKey();
        }

        static Empleado CrearEmpleado(int id, string nombre)
        {
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Fecha ingreso (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
            Console.Write("Salario: ");
            decimal.TryParse(Console.ReadLine(), out decimal salario);
            return new Empleado(id, nombre, apellido, fecha, salario);
        }

        static Estudiante CrearEstudiante(int id, string nombre)
        {
            Console.Write("Carrera: ");
            string carrera = Console.ReadLine();
            Console.Write("Año ingreso: ");
            int.TryParse(Console.ReadLine(), out int año);
            return new Estudiante(id, nombre, carrera, año);
        }

        static ExAlumno CrearExAlumno(int id, string nombre)
        {
            Console.Write("Carrera: ");
            string carrera = Console.ReadLine();
            Console.Write("Fecha Egreso (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
            return new ExAlumno(id, nombre, carrera, fecha);
        }

        static Docente CrearDocente(int id, string nombre)
        {
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Fecha ingreso (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
            Console.Write("Salario: ");
            decimal.TryParse(Console.ReadLine(), out decimal salario);
            Console.Write("Departamento: ");
            string depto = Console.ReadLine();
            Console.Write("Fecha nombramiento (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fechaNom);
            return new Docente(id, nombre, apellido, fecha, salario, depto, fechaNom);
        }

        static Administrativo CrearAdministrativo(int id, string nombre)
        {
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Fecha ingreso (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
            Console.Write("Salario: ");
            decimal.TryParse(Console.ReadLine(), out decimal salario);
            Console.Write("Puesto: ");
            string puesto = Console.ReadLine();
            Console.Write("Departamento: ");
            string depto = Console.ReadLine();
            return new Administrativo(id, nombre, apellido, fecha, salario, puesto, depto);
        }

        static Administrador CrearAdministrador(int id, string nombre)
        {
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Fecha ingreso (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
            Console.Write("Salario: ");
            decimal.TryParse(Console.ReadLine(), out decimal salario);
            Console.Write("Departamento: ");
            string depto = Console.ReadLine();
            Console.Write("Fecha nombramiento (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fechaNom);
            Console.Write("Área responsabilidad: ");
            string area = Console.ReadLine();
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            return new Administrador(id, nombre, apellido, fecha, salario, depto, fechaNom, area, cargo);
        }

        static Maestro CrearMaestro(int id, string nombre)
        {
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Fecha ingreso (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
            Console.Write("Salario: ");
            decimal.TryParse(Console.ReadLine(), out decimal salario);
            Console.Write("Departamento: ");
            string depto = Console.ReadLine();
            Console.Write("Fecha nombramiento (yyyy-mm-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime fechaNom);
            Console.Write("Especialidad: ");
            string especialidad = Console.ReadLine();
            Console.Write("Curso: ");
            string curso = Console.ReadLine();
            return new Maestro(id, nombre, apellido, fecha, salario, depto, fechaNom, especialidad, curso);
        }
    }
}
