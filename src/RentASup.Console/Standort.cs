using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace RentASup;

internal class Standort
{
    internal string Name { get; set; }
    internal string Adresse { get; set; }
    internal int AnzahlZweierSUP { get; set; } = 50;
    internal int AnzahlEinerSUP { get; set; } = 50;

    internal bool BestandPruefen(int sup1, int sup2)
    {        
        var bestand1er = BestandEinerPruefen(sup1);
        var bestand2er = BestandZweierPruefen(sup1);

        return (bestand1er && bestand2er);
    }

    private bool BestandEinerPruefen(int anzahl)
    {
        ConsoleWrapper.WriteLine($"1er SUP Bestand: {AnzahlEinerSUP}");
        if (AnzahlEinerSUP >= anzahl)
        {
            return true;
        }
        else
        {
            ConsoleWrapper.WriteLine($"Zu weniger 1er SUP an Lager. Bestand: {AnzahlEinerSUP}");
            return false;
        }
    }

    
    private bool BestandZweierPruefen(int anzahl)
    {
        ConsoleWrapper.WriteLine($"2er SUP Bestand: {AnzahlZweierSUP}");
        if (AnzahlZweierSUP >= anzahl)
        {
            return true;
        }
        else
        {
            ConsoleWrapper.WriteLine($"Zu weniger 2er SUP an Lager. Bestand: {AnzahlZweierSUP}");
            return false;
        }
    }

    internal void Print()
    {
        ConsoleWrapper.WriteLine($"1er SUPs: {AnzahlEinerSUP}");
        ConsoleWrapper.WriteLine($"2er SUPs: {AnzahlZweierSUP}");
    }

    internal void RemoveEinerSUP(int anzahl)
    {
        if (AnzahlEinerSUP > anzahl && anzahl > 0)
        {
            AnzahlEinerSUP -= anzahl;
        }
    }
    internal void RemoveZweierSUP(int anzahl)
    {
        if (AnzahlZweierSUP > anzahl && anzahl > 0)
        {
            AnzahlZweierSUP -= anzahl;
        }
    }

    internal void AddEinerSUP(int anzahl)
    {
        if (AnzahlEinerSUP > anzahl && anzahl > 0)
        {
            AnzahlEinerSUP += anzahl;
        }
    }
    internal void AddZweierSUP(int anzahl)
    {
        if (AnzahlZweierSUP > anzahl && anzahl > 0)
        {
            AnzahlZweierSUP += anzahl;
        }
    }
}