namespace RentASup.Gepaeck;

using RentASup.Bestand;

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
        ConsoleWrapper.WriteLine("Gepäck wird transportiert.");
    }

    internal void Markieren()
    {
        ConsoleWrapper.WriteLine("Gepäck wurde markiert.");
    }
    
    internal void Registrieren()
    {
        ConsoleWrapper.WriteLine($"Gepäck wurde registriert. Gepäck ID: {Id}");
    }
}