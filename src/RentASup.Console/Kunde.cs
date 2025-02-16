namespace RentASup;

internal class Kunde
{
    internal int Id { get; set; }
    internal string Name { get; set; }
    internal string Adresse { get; set; }
    internal int PLZ { get; set; }
    internal string Ort {get; set; }

    public Kunde (int id, string name, string adresse, int plz, string ort)
    {
        Id = id;
        Name = name;
        Adresse = adresse;
        PLZ = plz;
        Ort = ort;
    }
    
    internal void print()
    {
        ConsoleWrapper.WriteLine($"Kunde");
        ConsoleWrapper.WriteLine($"ID:      {Id}");
        ConsoleWrapper.WriteLine($"Adresse: {Adresse}");
        ConsoleWrapper.WriteLine($"PLZ:     {PLZ}");
        ConsoleWrapper.WriteLine($"Ort:     {Ort}");
        ConsoleWrapper.WriteLine("");
    }
}
