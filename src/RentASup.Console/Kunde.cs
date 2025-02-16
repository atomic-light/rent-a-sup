namespace RentASup;

internal class Kunde
{
    internal int Kundennummer { get; set; }
    internal string Name { get; set; }
    internal string Adresse { get; set; }
    internal int PLZ { get; set; }
    internal string Ort {get; set; }

    public Kunde (int kundennummer, string name, string adresse, int plz, string ort)
    {
        Kundennummer = kundennummer;
        Name = name;
        Adresse = adresse;
        PLZ = plz;
        Ort = ort;
    }
    
    internal void print()
    {
        ConsoleWrapper.WriteLine($"Kundennummer: {Kundennummer}, Adresse: {Adresse}, {Ort}");
    }
}
