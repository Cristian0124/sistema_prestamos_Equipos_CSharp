
Inventario inventario = new Inventario();
int opcion;

do
{
    Console.WriteLine("\n=== SISTEMA DE PRÉSTAMOS ===");
    Console.WriteLine("1. Registrar equipo");
    Console.WriteLine("2. Listar equipos");
    Console.WriteLine("3. Prestar equipo");
    Console.WriteLine("4. Devolver equipo");
    Console.WriteLine("5. Consultar disponibilidad");
    Console.WriteLine("6. Resumen");
    Console.WriteLine("7. Salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
        opcion = 0;

    switch (opcion)
    {
        case 1: inventario.Registrar(); break;
        case 2: inventario.Listar(); break;
        case 3: inventario.Prestar(); break;
        case 4: inventario.Devolver(); break;
        case 5: inventario.ConsultarDisponibilidad(); break;
        case 6: inventario.MostrarResumen(); break;
        case 7: Console.WriteLine("Hasta pronto."); break;
        default: Console.WriteLine("Opción inválida."); break;
    }

} while (opcion != 7);