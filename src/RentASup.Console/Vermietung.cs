using System.Data.Common;
using System.Diagnostics;

namespace RentASup;

internal class Vermietung
{
    internal int Id { get; set; }
    internal DateTime Datum { get; set; }
    internal string Status { get; set; }
    internal Kunde Kunde { get; set; }
    internal int AnzahlEinerSUP { get; set; }
    internal int AnzahlZweierSUP { get; set; }
    internal Gepaeck? Gepaeck { get; set; }
    internal Standort Standort { get; set; }

    public Vermietung(Kunde kunde, Standort standort)
    {
        Id = 1111;
        Datum = DateTime.Now;
        Status = "Initialisiert";
        Kunde = kunde;
        Standort = standort;
    }

    internal void AddGepaeck(Gepaeck gepaeck)
    {
        Gepaeck = gepaeck;
    }

    internal void Bestaetigen(int anzahlEinerSUP, int anzahlZweierSUP)
    {
        Status = "Bestätigt";
        AnzahlEinerSUP = anzahlEinerSUP;
        AnzahlZweierSUP = anzahlZweierSUP;
    }

    internal void Print()
    {
        ConsoleWrapper.PrintTitle($"Vermietung");
        ConsoleWrapper.WriteLine($"ID:                  {Id}");
        ConsoleWrapper.WriteLine($"Datum:               {Datum}");
        ConsoleWrapper.WriteLine($"Status:              {Status}");
        ConsoleWrapper.WriteLine($"Kunden ID:           {Kunde.Id}");
        ConsoleWrapper.WriteLine($"Kunde:               {Kunde.Name}");
        ConsoleWrapper.WriteLine($"Anzahl Einer-SUP:    {AnzahlEinerSUP}");
        ConsoleWrapper.WriteLine($"Anzahl Zweier-SUP:   {AnzahlZweierSUP}");
        ConsoleWrapper.WriteLine($"Gepäck:              {(Gepaeck != null ? Gepaeck.Id.ToString() : "Kein Gepäck")}");
    }
}

