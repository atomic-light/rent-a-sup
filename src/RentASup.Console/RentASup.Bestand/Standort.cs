namespace RentASup.Bestand;

internal class Standort
{
    internal int Id { get; set; }
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
        if (AnzahlEinerSUP >= anzahl)
        {
            return true;
        }
        else
        {
            ConsoleWrapper.WriteLine($"Zu weniger 1er SUP an Lager.");
            return false;
        }
    }

    
    private bool BestandZweierPruefen(int anzahl)
    {
        if (AnzahlZweierSUP >= anzahl)
        {
            return true;
        }
        else
        {
            ConsoleWrapper.WriteLine($"Zu weniger 2er SUP an Lager.");
            return false;
        }
    }

    internal void Print()
    {
        ConsoleWrapper.WriteLine("Aktueller SUP Bestand");
        ConsoleWrapper.WriteLine($"1er SUPs: {AnzahlEinerSUP}");
        ConsoleWrapper.WriteLine($"2er SUPs: {AnzahlZweierSUP}");
    }

    internal void RemoveEinerSUP(int anzahl)
    {
        if (AnzahlEinerSUP > anzahl && anzahl > 0)
        {
            AnzahlEinerSUP -= anzahl;
        }
        else
        {
            ConsoleWrapper.WriteLine("Zu wenig 1er SUP an Lager.");
            Print();
        }
    }

    internal void RemoveZweierSUP(int anzahl)
    {
        if (AnzahlZweierSUP > anzahl && anzahl > 0)
        {
            AnzahlZweierSUP -= anzahl;
        }
        else
        {
            ConsoleWrapper.WriteLine("Zu wenig 2er SUP an Lager.");
            Print();
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