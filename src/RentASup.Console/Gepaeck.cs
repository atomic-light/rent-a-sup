namespace RentASup;

internal class Gepaeck
{
    internal int GepaeckId { get; set; }
    internal Kunde Besitzer { get; set; }
    internal string Status { get; set; }

    internal void Transportieren()
    {
        Console.WriteLine("Gepäck wird transportiert.");
    }

    internal void Markieren()
    {
        Console.WriteLine("Gepäck wurde markiert.");
    }
}