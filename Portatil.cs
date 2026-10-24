
public class Portatil : Equipo
{
    public string Marca { get; private set; }
    public int MemoriaRam { get; private set; }

    public Portatil(int id, string nombre, string marca, int memoriaRam)
        : base(id, nombre)
    {
        Marca = marca;
        MemoriaRam = memoriaRam;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine(
            $"ID: {Id} | Portátil: {Nombre} | Marca: {Marca} | RAM: {MemoriaRam} GB | Disponible: {(Disponible ? "Sí" : "No")}"
        );
    }
}

