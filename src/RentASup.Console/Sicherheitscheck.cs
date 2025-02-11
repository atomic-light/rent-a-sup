namespace RentASup;

internal class Sicherheitscheck
{
    internal int Kundennummer { get;set; }
    internal string Sicherheitsinfo { get; set; }
    internal DateTime Datum { get; set; }
    internal bool Bestaetigt { get; set; }

    internal bool Bestaetigen(Kunde kunde)
    {
        Bestaetigt = true;
        return Bestaetigt;
    }
}