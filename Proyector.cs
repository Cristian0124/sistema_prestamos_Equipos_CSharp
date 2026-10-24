
public class Proyector : Equipo
{
    public int Luminosidad { get; private set; }
    public string Resolucion { get; private set; }

    public Proyector(int id, string nombre, int luminosidad, string resolucion)
        : base(id, nombre)
    {
        Luminosidad = luminosidad;
        Resolucion = resolucion;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine(
            $"ID: {Id} | Proyector: {Nombre} | Luminosidad: {Luminosidad} lúmenes | Resolución: {Resolucion} | Disponible: {(Disponible ? "Sí" : "No")}"
        );
    }
}

