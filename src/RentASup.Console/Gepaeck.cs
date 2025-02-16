namespace RentASup;

internal class Gepaeck
{
    internal int Id { get; set; }
    internal Kunde Besitzer { get; set; }
    internal Standort Standort { get; set; }
    public Gepaeck(int id, Kunde kunde, Standort standort)
    {
        Id = id;
        Besitzer = kunde;
        Standort = standort;
    }

    internal void Transportieren()
    {
        Console.WriteLine("Gepäck wird transportiert.");
    }

    internal void Markieren()
    {
        Console.WriteLine("Gepäck wurde markiert.");
    }
    
    internal void Registrieren()
    {
        Console.WriteLine($"Gepäck wurde registriert. Gepäck ID: {Id}");
    }
}