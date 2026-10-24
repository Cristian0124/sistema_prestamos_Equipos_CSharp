
using System;
using System.Collections.Generic;
using System.Linq;

public class Inventario
{
    private List<Equipo> equipos = new List<Equipo>();

    public void Registrar()
    {
        Console.WriteLine("\n=== REGISTRAR EQUIPO ===");
        Console.WriteLine("1. Portátil");
        Console.WriteLine("2. Tableta");
        Console.WriteLine("3. Proyector");

        int tipo = LeerEntero("Seleccione el tipo: ");
        int id = LeerEntero("Ingrese el ID: ");

        if (equipos.Any(e => e.Id == id))
        {
            Console.WriteLine("Ya existe un equipo con ese ID.");
            return;
        }

        Console.Write("Ingrese el nombre: ");
        string nombre = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("El nombre no puede estar vacío.");
            return;
        }

        Equipo? equipo = null;

        switch (tipo)
        {
            case 1:
                Console.Write("Marca: ");
                string marcaPortatil = Console.ReadLine() ?? "";

                int ram = LeerEntero("Memoria RAM en GB: ");

                if (ram <= 0)
                {
                    Console.WriteLine("La memoria RAM debe ser mayor que cero.");
                    return;
                }

                equipo = new Portatil(id, nombre, marcaPortatil, ram);
                break;

            case 2:
                Console.Write("Marca: ");
                string marcaTableta = Console.ReadLine() ?? "";

                double pantalla = LeerDouble("Tamaño de pantalla en pulgadas: ");

                if (pantalla <= 0)
                {
                    Console.WriteLine("El tamaño debe ser mayor que cero.");
                    return;
                }

                equipo = new Tableta(id, nombre, marcaTableta, pantalla);
                break;

            case 3:
                int luminosidad = LeerEntero("Luminosidad en lúmenes: ");

                if (luminosidad <= 0)
                {
                    Console.WriteLine("La luminosidad debe ser mayor que cero.");
                    return;
                }

                Console.Write("Resolución: ");
                string resolucion = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(resolucion))
                {
                    Console.WriteLine("La resolución no puede estar vacía.");
                    return;
                }

                equipo = new Proyector(id, nombre, luminosidad, resolucion);
                break;

            default:
                Console.WriteLine("Tipo de equipo inválido.");
                return;
        }

        equipos.Add(equipo);
        Console.WriteLine("Equipo registrado correctamente.");
    }

    public void Listar()
    {
        Console.WriteLine("\n=== LISTA DE EQUIPOS ===");

        if (equipos.Count == 0)
        {
            Console.WriteLine("No hay equipos registrados.");
            return;
        }

        foreach (Equipo equipo in equipos)
        {
            equipo.MostrarDetalles();
        }
    }

    public void Prestar()
    {
        Console.WriteLine("\n=== PRESTAR EQUIPO ===");

        int id = LeerEntero("Ingrese el ID del equipo: ");
        Equipo? equipo = equipos.FirstOrDefault(e => e.Id == id);

        if (equipo == null)
        {
            Console.WriteLine("No se encontro un equipo con ese ID.");
            return;
        }

        if (equipo.Prestar())
            Console.WriteLine("Prestamo realizado correctamente.");
        else
            Console.WriteLine("El equipo ya esta prestado.");
    }

    public void Devolver()
    {
        Console.WriteLine("\n=== DEVOLVER EQUIPO ===");

        int id = LeerEntero("Ingrese el ID del equipo: ");
        Equipo? equipo = equipos.FirstOrDefault(e => e.Id == id);

        if (equipo == null)
        {
            Console.WriteLine("No se encontro un equipo con ese ID.");
            return;
        }

        if (equipo.Devolver())
            Console.WriteLine("Equipo devuelto correctamente.");
        else
            Console.WriteLine("El equipo ya estaba disponible.");
    }

    public void ConsultarDisponibilidad()
    {
        Console.WriteLine("\n=== CONSULTAR DISPONIBILIDAD ===");

        int id = LeerEntero("Ingrese el ID del equipo: ");
        Equipo? equipo = equipos.FirstOrDefault(e => e.Id == id);

        if (equipo == null)
        {
            Console.WriteLine("No se encontro un equipo con ese ID.");
            return;
        }

        Console.WriteLine(
            $"Equipo: {equipo.Nombre} | Disponible: {(equipo.Disponible ? "Sí" : "No")}"
        );
    }

    public void MostrarResumen()
    {
        int disponibles = equipos.Count(e => e.Disponible);
        int prestados = equipos.Count - disponibles;

        Console.WriteLine("\n=== RESUMEN DEL INVENTARIO ===");
        Console.WriteLine($"Total de equipos: {equipos.Count}");
        Console.WriteLine($"Equipos disponibles: {disponibles}");
        Console.WriteLine($"Equipos prestados: {prestados}");
    }

    private int LeerEntero(string mensaje)
    {
        int valor;

        while (true)
        {
            Console.Write(mensaje);

            if (int.TryParse(Console.ReadLine(), out valor))
                return valor;

            Console.WriteLine("Ingrese un número entero válido.");
        }
    }

    private double LeerDouble(string mensaje)
    {
        double valor;

        while (true)
        {
            Console.Write(mensaje);

            string entrada = (Console.ReadLine() ?? "").Replace(',', '.');

            if (double.TryParse(
                entrada,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out valor))
            {
                return valor;
            }

            Console.WriteLine("Ingrese un número válido. Ejemplo: 10.5");
        }
    }
}

