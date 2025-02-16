using System.Data.Common;
using System.Diagnostics;

namespace RentASup;

internal class Vermietung
{
    internal int Buchungsnummer { get; set; }
    internal DateTime Datum { get; set; }
    internal string Status { get; set; }
    internal Kunde Kunde { get; set; }
    internal int AnzahlEinerSUP { get; set; }
    internal int AnzahlZweierSUP { get; set; }
    internal Gepaeck? Gepaeck { get; set; }

    public Vermietung(Kunde kunde)
    {
        Buchungsnummer = 1111;
        Datum = DateTime.Now;
        Status = "Initialisiert";
        Kunde = kunde;
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
}

