
public abstract class Equipo
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public bool Disponible { get; private set; }
    public Equipo(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
        Disponible = true;
    }

    public bool Prestar()
    {
        if (!Disponible)
            return false;

        Disponible = false;
        return true;
    }

    public bool Devolver()
    {
        if (Disponible)
            return false;

        Disponible = true;
        return true;
    }

    public abstract void MostrarDetalles();
}
