# Sistema de Préstamos de Equipos Tecnológicos

Aplicación de consola en C# para administrar el inventario y los préstamos de portátiles, tabletas y proyectores.

## Requisitos
- .NET SDK 8.0 o superior.

## Ejecutar
Desde la carpeta del proyecto:

```bash
dotnet run
```

## Funcionalidades
1. Registrar portátiles, tabletas y proyectores.
2. Listar equipos con detalles específicos por tipo.
3. Prestar equipos disponibles.
4. Registrar devoluciones.
5. Consultar disponibilidad por ID.
6. Mostrar el resumen de equipos disponibles y prestados.
7. Rechazar IDs duplicados y operaciones de préstamo/devolución inválidas.

## Conceptos de POO
- **Abstracción:** clase abstracta `Equipo`.
- **Encapsulamiento:** propiedades con `private set`; la disponibilidad se cambia con `Prestar()` y `Devolver()`.
- **Herencia:** `Portatil`, `Tableta` y `Proyector` heredan de `Equipo`.
- **Polimorfismo:** cada clase sobrescribe `MostrarDetalles()` y se invoca al recorrer `List<Equipo>`.

Los datos se mantienen en memoria mientras el programa está en ejecución, como permite la guía del taller.
