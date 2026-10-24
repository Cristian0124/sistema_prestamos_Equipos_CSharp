
public class Tableta : Equipo
{
    public string Marca { get; private set; }
    public double TamañoPantalla { get; private set; }

    public Tableta(int id, string nombre, string marca, double tamañoPantalla)
        : base(id, nombre)
    {
        Marca = marca;
        TamañoPantalla = tamañoPantalla;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine(
            $"ID: {Id} | Tableta: {Nombre} | Marca: {Marca} | Pantalla: {TamañoPantalla} pulgadas | Disponible: {(Disponible ? "Sí" : "No")}"
        );
    }
}

